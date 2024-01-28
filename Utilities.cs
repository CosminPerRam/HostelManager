using System.Text.Json;

namespace HotelMan
{
    public class Utilities
    {
        private static JsonSerializerOptions jsonOptions = new JsonSerializerOptions { IncludeFields = true };

        public delegate object Func();

        static object runSafely(Func func)
        {
            try
            {
                return func();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return new object();
        }

        public static void Save(object item)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|json files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string contentToSave = JsonSerializer.Serialize(item, jsonOptions);
                File.WriteAllText(filePath, contentToSave);
            }
        }

        public static T? Load<T>()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|json files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileContent = File.ReadAllText(filePath);

                return JsonSerializer.Deserialize<T>(fileContent, jsonOptions);
            }

            return default;
        }
    }
}
