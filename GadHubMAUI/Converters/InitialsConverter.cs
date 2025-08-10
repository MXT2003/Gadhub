using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace GadHubMAUI.Converters
{
    public class InitialsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || !(value is string))
                return "?"; // Giá trị mặc định nếu không phải chuỗi

            string fullName = (string)value;
            if (string.IsNullOrWhiteSpace(fullName))
                return "?"; // Giá trị mặc định nếu chuỗi rỗng

            // Tách tên thành các từ
            string[] words = Regex.Split(fullName.Trim(), @"\s+");

            if (words.Length == 1)
            {
                // Nếu chỉ có một từ, lấy ký tự đầu tiên
                return words[0].Substring(0, 1).ToUpper();
            }
            else
            {
                // Lấy ký tự đầu tiên của từ đầu tiên và từ cuối cùng
                return (words[0].Substring(0, 1) + words[words.Length - 1].Substring(0, 1)).ToUpper();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}