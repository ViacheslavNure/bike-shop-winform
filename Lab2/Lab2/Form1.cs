using AutoMapper;
using Lab2.DbConnection;
using Lab2.DbConnection.DbContext;
using Lab2.DbConnection.Entities;
using Lab2.Extensions;
using Lab2.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection.Metadata.Ecma335;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private readonly BikeRepository bikeRepository;
        private BikeViewModel selectedBikeViewModel;
        private IMapper mapper;

        public Form1(IServiceProvider services)
        {
            InitializeComponent();

            var dbContext = services.GetRequiredService<BikeShopDbContext>();
            bikeRepository = new BikeRepository(dbContext);
            mapper = services.GetRequiredService<IMapper>();

            LoadBikesList(bikesListView);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                var price = Convert.ToDecimal(priceTb.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Price is in incorrect format. Please enter the valid value.");
            }

            var newBike = new Bike
            {
                BrandName = brandTb.Text,
                BikeType = new BikeType
                {
                    Name = bikeTypeNameCb.Text
                },
                Description = descriptionTb.Text,
                Model = modelTb.Text,
                Price = Convert.ToDecimal(priceTb.Text)
            };

            bikeRepository.AddBike(newBike);

            MessageBox.Show($"Bike was successfully added.");
            ClearAddBikeForm();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bikesListView.SelectedItems.Count != 1)
            {
                return;
            }

            var bikeId = Guid.Parse(bikesListView.SelectedItems[0].Text);
            var selectedBike = bikeRepository.GetBikeById(bikeId);
            selectedBikeViewModel = mapper.Map<BikeViewModel>(selectedBike);

            bikeTypeNameUpdateCb.Items.Clear();
            brandUpdateTb.Text = selectedBikeViewModel.BrandName;
            modelUpdateTb.Text = selectedBikeViewModel.Model;

            LoadBikeTypesList(bikeTypeNameUpdateCb);
            bikeTypeNameUpdateCb.SelectedItem = selectedBikeViewModel.BikeType.Name;

            bikeTypeDescriptionUpdateLab.Text = selectedBikeViewModel.BikeType.Description;
            descriptionUpdateTb.Text = selectedBikeViewModel.Description;
            var s = selectedBikeViewModel.Price.ToString("F2");
            priceUpdateTb.Text = $"${selectedBikeViewModel.Price.ToString("F2")}";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    LoadBikesList(bikesListView);
                    break;
                case 1:
                    LoadBikeTypesList(bikeTypeNameCb);
                    LoadBikeTypesList(bikeTypeDeleteCb);
                    break;
                case 2:
                    LoadBikesList(bikesFeedbackListView);
                    break;
                default:
                    return;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var bike = new BikeViewModel
            {
                BrandName = brandUpdateTb.Text,
                BikeType = new BikeTypeViewModel
                {
                    Name = bikeTypeNameUpdateCb.Text,
                    Description = bikeTypeDescriptionUpdateLab.Text
                },
                Description = descriptionUpdateTb.Text,
                Model = modelUpdateTb.Text,
                Price = Convert.ToDecimal(priceUpdateTb.Text.Substring(1))
            };

            if (!selectedBikeViewModel.Equals(bike))
            {
                selectedBikeViewModel.Price = bike.Price;
                selectedBikeViewModel.BrandName = bike.BrandName;
                selectedBikeViewModel.Model = bike.Model;
                selectedBikeViewModel.Description = bike.Description;
                selectedBikeViewModel.BikeType.Name = bike.BikeType.Name;
                selectedBikeViewModel.BikeType.Description = bike.BikeType.Description;


                var selectedBikeEntity = mapper.Map<Bike>(selectedBikeViewModel);
                bikeRepository.UpdateBike(selectedBikeEntity);
                LoadBikesList(bikesListView);

                MessageBox.Show("Bike was successfully updated.");
            }
        }

        private void bikeTypeNameUpdateCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            bikeTypeDescriptionUpdateLab.Text = GetBikeTypeDescriptionByName(bikeTypeNameUpdateCb.Text);
        }

        private void bikeTypeNameCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            bikeTypeDescriprionLab.Text = GetBikeTypeDescriptionByName(bikeTypeNameCb.Text);
        }

        private string GetBikeTypeDescriptionByName(string bikeTypeName)
        {
            var bikeType = bikeRepository.GetBikeTypeByName(bikeTypeName);

            return bikeType.Description;
        }

        private void LoadBikesList(ListView listView)
        {
            selectedBikeViewModel = null!;
            var bikeViewModelsList = bikeRepository.GetBikeList().Select(mapper.Map<BikeViewModel>).ToList();
            listView.PopulateBikesListView(bikeViewModelsList);
        }

        private void LoadBikeTypesList(ComboBox bikeTypeNamesCombobx)
        {
            var bikeTypeNamesArray = bikeRepository
                        .GetBikeTypes()
                        .Select(mapper.Map<BikeTypeViewModel>)
                        .Select(x => x.Name)
                        .ToArray();

            bikeTypeNamesCombobx.Items.Clear();
            bikeTypeNamesCombobx.Items.AddRange(bikeTypeNamesArray);
        }

        private void LoadFeedbacks(ListView listView)
        {
            var feedbacksViewModelsList = bikeRepository.GetBikeList().Select(mapper.Map<FeedbackViewModel>).ToList();
            listView.PopulateFeedbacksListView(feedbacksViewModelsList);
        }

        private void ClearAddBikeForm()
        {
            brandTb.Text = string.Empty;
            modelTb.Text = string.Empty;
            descriptionTb.Text = string.Empty;
            bikeTypeNameCb.Text = string.Empty;
            bikeTypeDescriprionLab.Text = string.Empty;
            priceTb.Text = string.Empty;
        }

        private void ClearAddBikeTypeForm()
        {
            bikeTypeNameAddTb.Text = string.Empty;
            bikeTypeDescriptionAddTb.Text = string.Empty;
        }

        private void addBikeTypeButton_Click(object sender, EventArgs e)
        {
            var bikeType = new BikeType
            {
                Name = bikeTypeNameAddTb.Text,
                Description = bikeTypeDescriptionAddTb.Text
            };
            bikeRepository.AddBikeType(bikeType);

            ClearAddBikeTypeForm();

            MessageBox.Show("Bike type was successfully added.");
        }

        private void deleteBikeButton_Click(object sender, EventArgs e)
        {
            if (selectedBikeViewModel is not null)
            {
                bikeRepository.DeleteBike(selectedBikeViewModel.Id);

                LoadBikesList(bikesListView);
            }
        }

        private void bikeTypeDeleteButton_Click(object sender, EventArgs e)
        {
            var bikeTypeName = bikeTypeDeleteCb.Text;

            if (!string.IsNullOrWhiteSpace(bikeTypeName))
            {
                bikeRepository.DeleteBikeType(bikeTypeName);

                bikeTypeDeleteCb.Text = string.Empty;
                LoadBikeTypesList(bikeTypeNameCb);
                LoadBikeTypesList(bikeTypeDeleteCb);
            }
        }

        private void bikesFeedbackListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bikeId = Guid.Parse(bikesFeedbackListView.SelectedItems[0].Text);
            var selectedBike = bikeRepository.GetBikeById(bikeId);
            selectedBikeViewModel = mapper.Map<BikeViewModel>(selectedBike);

            brandFeedbackLab.Text = selectedBikeViewModel.BrandName;
            modelFeedbackLab.Text = selectedBikeViewModel.Model;
            descriptionFeedbackTb.Text = selectedBikeViewModel.Description;

            LoadFeedbacks(feedbacksListView);
        }

        private void sendFeedbackButton_Click(object sender, EventArgs e)
        {
            if(selectedBikeViewModel is null)
            {
                return;
            }

            var feedBack = new Feedback
            {
                Content = feedbackContentTb.Text,
                BikeId = selectedBikeViewModel.Id,
            };

            bikeRepository.AddFeedback(feedBack);

            LoadFeedbacks(feedbacksListView);
        }
    }
}
