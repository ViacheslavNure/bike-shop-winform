using Lab2.DbConnection.Entities;

namespace Lab2.Extensions
{
    public static class ListViewExtensions
    {
        public static void PopulateListView(this ListView listView, List<Bike> bikes)
        {
            listView.Items.Clear();

            foreach (var bike in bikes)
            {
                var item = new ListViewItem(bike.Id.ToString());
                item.SubItems.Add(bike.BrandName);
                item.SubItems.Add(bike.Model);
                item.SubItems.Add(bike.Price.ToString("C"));
                listView.Items.Add(item);
            }
        }
    }
}
