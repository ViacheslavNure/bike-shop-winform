using AutoMapper;
using BikeShop.Application.Services.Interfaces;
using BikeShop.Application.ViewModels;
using BikeShop.Presentation.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace BikeShop.Presentation
{
    public partial class Form1 : Form
    {
        private readonly IBikeService bikeService;
        private BikeViewModel selectedBikeViewModel;
        private IMapper mapper;

        public Form1(IServiceProvider services)
        {
            InitializeComponent();

            bikeService = services.GetRequiredService<IBikeService>();

            mapper = services.GetRequiredService<IMapper>();
            mapper.ConfigurationProvider.AssertConfigurationIsValid();

            LoadBikesList(bikesListView);
        }

        private void addButton_Click(object sender, EventArgs e) =>
            ExceptionHandler.RunWithExceptionHandling((sender, e) =>
            {
                var newBike = new BikeViewModel
                {
                    BrandName = brandTb.Text,
                    BikeType = new BikeTypeViewModel
                    {
                        Name = bikeTypeNameCb.Text
                    },
                    Description = descriptionTb.Text,
                    Model = modelTb.Text,
                    Price = priceTb.Text
                };

                bikeService.AddBike(newBike);
                ClearAddBikeForm();
            });

        private void bikesListView_SelectedIndexChanged(object sender, EventArgs e) =>
            ExceptionHandler.RunWithExceptionHandling((sender, e) =>
            {
                if (bikesListView.SelectedItems.Count != 1)
                {
                    return;
                }

                var bikeId = Guid.Parse(bikesListView.SelectedItems[0].Text);

                selectedBikeViewModel = bikeService.GetBikeById(bikeId);

                DisplayBikeDetails();
            });

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) =>
            ExceptionHandler.RunWithExceptionHandling((sender, e) =>
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        LoadBikesList(bikesListView);
                        LoadBikeTypesList(bikeTypeNameUpdateCb);
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
            });

        private void updateButton_Click(object sender, EventArgs e) =>
            ExceptionHandler.RunWithExceptionHandling((sender, e) =>
            {
                var bike = new BikeViewModel
                {
                    Id = selectedBikeViewModel.Id,
                    BrandName = brandUpdateTb.Text ?? string.Empty,
                    BikeType = new BikeTypeViewModel
                    {
                        Name = bikeTypeNameUpdateCb.Text,
                        Description = bikeTypeDescriptionUpdateLab.Text,
                    },
                    Description = descriptionUpdateTb.Text ?? string.Empty,
                    Model = modelUpdateTb.Text ?? string.Empty,
                    Price = priceUpdateTb.Text ?? string.Empty
                };

                if (!selectedBikeViewModel.Equals(bike))
                {
                    
                    bikeService.UpdateBike(bike);
                    LoadBikesList(bikesListView);

                    MessageBox.Show("Bike was successfully updated.");
                }
            });

        private void bikeTypeNameCb_SelectedIndexChanged(object sender, EventArgs e) =>
            ExceptionHandler.RunWithExceptionHandling((sender, e) =>
            {
                bikeTypeDescriptionUpdateLab.Text = bikeService.GetBikeTypeByName(bikeTypeNameUpdateCb.Text).Description;
            });

        

        private void addBikeTypeButton_Click(object sender, EventArgs e) =>
            ExceptionHandler.RunWithExceptionHandling((sender, e) =>
            {
                bikeService.AddBikeType(new BikeTypeViewModel
                {
                    Name = bikeTypeNameAddTb.Text,
                    Description = bikeTypeDescriptionAddTb.Text
                });

                ClearAddBikeTypeForm();

                MessageBox.Show("Bike type was successfully added.");

                LoadBikeTypesList(bikeTypeNameCb);
                LoadBikeTypesList(bikeTypeDeleteCb);
            });

        

        private void deleteBikeButton_Click(object sender, EventArgs e) =>
            ExceptionHandler.RunWithExceptionHandling((sender, e) =>
            {
                if (selectedBikeViewModel is not null)
                {
                    bikeService.DeleteBikeById(selectedBikeViewModel.Id);

                    ClearUpdateBikeForm();
                    LoadBikesList(bikesListView);
                }
            });
        

        private void bikeTypeDeleteButton_Click(object sender, EventArgs e) =>
            ExceptionHandler.RunWithExceptionHandling((sender, e) =>
            {
                var bikeTypeName = bikeTypeDeleteCb.Text;

                if (!string.IsNullOrWhiteSpace(bikeTypeName))
                {
                    bikeService.DeleteBikeTypeByName(bikeTypeName);

                    bikeTypeDeleteCb.Text = string.Empty;
                    LoadBikeTypesList(bikeTypeNameCb);
                    LoadBikeTypesList(bikeTypeDeleteCb);
                }
            });
        

        private void bikesFeedbackListView_SelectedIndexChanged(object sender, EventArgs e) =>
            ExceptionHandler.RunWithExceptionHandling((sender, e) =>
            {
                if (bikesFeedbackListView.SelectedItems.Count != 1)
                {
                    return;
                }

                selectedBikeViewModel = bikeService.GetBikeById(Guid.Parse(bikesFeedbackListView.SelectedItems[0].Text));

                brandFeedbackLab.Text = selectedBikeViewModel.BrandName;
                modelFeedbackLab.Text = selectedBikeViewModel.Model;
                descriptionFeedbackTb.Text = selectedBikeViewModel.Description;

                LoadFeedbacks(feedbacksListView);
            });
        

        private void sendFeedbackButton_Click(object sender, EventArgs e) =>
            ExceptionHandler.RunWithExceptionHandling((sender, e) =>
            {
                if (selectedBikeViewModel is null)
                {
                    return;
                }

                var feedBack = new FeedbackViewModel
                {
                    Content = feedbackContentTb.Text,
                    BikeId = selectedBikeViewModel.Id
                };

                bikeService.AddFeedback(feedBack);

                LoadFeedbacks(feedbacksListView);
            });
        

        private void feedbacksListView_SelectedIndexChanged(object sender, EventArgs e) =>
            ExceptionHandler.RunWithExceptionHandling((sender, e) =>
            {
                if (feedbacksListView.SelectedItems.Count != 1)
                {
                    return;
                }

                var content = bikeService.GetFeedbackContentById(Guid.Parse(feedbacksListView.SelectedItems[0].Text));

                MessageBox.Show(content, "Feedback Content");
            });
        

        private void DisplayBikeDetails()
        {
            bikeTypeNameUpdateCb.Items.Clear();
            brandUpdateTb.Text = selectedBikeViewModel.BrandName;
            modelUpdateTb.Text = selectedBikeViewModel.Model;

            LoadBikeTypesList(bikeTypeNameUpdateCb);
            bikeTypeNameUpdateCb.SelectedItem = selectedBikeViewModel.BikeType.Name;

            bikeTypeDescriptionUpdateLab.Text = selectedBikeViewModel.BikeType.Description;
            descriptionUpdateTb.Text = selectedBikeViewModel.Description;
            priceUpdateTb.Text = selectedBikeViewModel.Price;
        }

        private void LoadBikesList(ListView listView)
        {
            selectedBikeViewModel = null!;
            listView.PopulateBikesListView(bikeService.GetBikesList());
        }

        private void LoadBikeTypesList(ComboBox bikeTypeNamesCombobx)
        {
            var bikeTypeNamesArray = bikeService
                        .GetBikeTypesList()
                        .Select(x => x.Name)
                        .ToArray();

            bikeTypeNamesCombobx.Items.Clear();
            bikeTypeNamesCombobx.Items.AddRange(bikeTypeNamesArray);
        }

        private void LoadFeedbacks(ListView listView)
        {
            if (selectedBikeViewModel is null)
            {
                return;
            }

            listView.PopulateFeedbacksListView(bikeService.GetFeedbacksByBikeId(selectedBikeViewModel.Id));
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
        private void ClearUpdateBikeForm()
        {
            brandUpdateTb.Text = string.Empty;
            modelUpdateTb.Text = string.Empty;
            descriptionUpdateTb.Text = string.Empty;
            bikeTypeNameUpdateCb.Text = string.Empty;
            bikeTypeDescriptionUpdateLab.Text = string.Empty;
            priceUpdateTb.Text = string.Empty;
        }

        private void ClearAddBikeTypeForm()
        {
            bikeTypeNameAddTb.Text = string.Empty;
            bikeTypeDescriptionAddTb.Text = string.Empty;
        }
    }
}
