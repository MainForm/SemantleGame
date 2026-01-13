using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace SemantleGame.Converters
{
    public class IntRangeToTextConverter : IValueConverter
    {
        public int Min { get; set; } = 0;
        public int Max { get; set; } = 1000;
        public string ErrorText { get; set; } = "1000 이상";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int number)
            {
                if (number >= Min && number <= Max)
                    return number.ToString();
            }

            return ErrorText;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // 출력 전용이므로 역변환은 지원하지 않음
            throw new NotSupportedException();
        }
    }
}
