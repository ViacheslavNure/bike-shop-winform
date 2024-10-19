using Lab2.DbConnection.Entities;
using Lab2.ViewModels;

namespace Lab2.Extensions
{
    public static class ListViewExtensions
    {
        public static void PopulateBikesListView(this ListView listView, List<BikeViewModel> bikes)
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

        public static void PopulateFeedbacksListView(this ListView listView, List<FeedbackViewModel> feedbacks)
        {
            listView.Items.Clear();

            foreach (var feedback in feedbacks)
            {
                var item = new ListViewItem(feedback.Id.ToString());
                item.SubItems.Add(feedback.CreationDate.ToString("d"));
                item.SubItems.Add(feedback.Content);
                listView.Items.Add(item);
            }
        }
    }
}
