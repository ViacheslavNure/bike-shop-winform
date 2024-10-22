namespace BikeShop.Presentation
{
    public static class ExceptionHandler
    {
        public static void RunWithExceptionHandling(Action<object, EventArgs> function, object sender = null!, EventArgs args = null!)
        {
            try
            {
                function(sender, args);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK);
            }
        }
    }
}
