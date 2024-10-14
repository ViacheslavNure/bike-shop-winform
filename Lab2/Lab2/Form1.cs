using Lab2.DbConnection;
using Lab2.DbConnection.DbContext;
using Lab2.DbConnection.Entities;
using Lab2.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private readonly BikeRepository bikeRepository;

        public Form1(IServiceProvider services)
        {
            InitializeComponent();

            var dbContext = services.GetRequiredService<BikeShopDbContext>();
            bikeRepository = new BikeRepository(dbContext);

            listView1.PopulateListView(bikeRepository.GetBikeList());
        }

        private void button1_Click(object sender, EventArgs e)
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
                    Name = bikeTypeTb.Text,
                    Description = bikeTypeDescriptionTb.Text,
                },
                Description = descriptionTb.Text,
                Model = modelTb.Text,
                Price = Convert.ToDecimal(priceTb.Text)
            };

            bikeRepository.AddBike(newBike);

            MessageBox.Show($"Bike was successfully added.");
            ClearAddBikeForm();
        }

        private void ClearAddBikeForm()
        {
            brandTb.Text = string.Empty;
            modelTb.Text = string.Empty;
            descriptionTb.Text = string.Empty;
            bikeTypeDescriptionTb.Text = string.Empty;
            bikeTypeTb.Text = string.Empty;
            priceTb.Text = string.Empty;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 1)
            {
                return;
            }

            var bikeId = Guid.Parse(listView1.SelectedItems[0].Text);
            var bike = bikeRepository.GetBikeById(bikeId);

            MessageBox.Show($"{bike.Model} {bike.BrandName}");

            listView1.SelectedItems.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                listView1.PopulateListView(bikeRepository.GetBikeList());
            }
        }
    }
}
