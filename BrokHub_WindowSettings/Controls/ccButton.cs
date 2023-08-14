using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BrokHub_WindowSettings.Controls
{
    public class ccButton : Button
    {
        static ccButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ccButton), new FrameworkPropertyMetadata(typeof(ccButton)));
        }




        public string SubTitle1
        {
            get { return (string)GetValue(SubTitle1Property); }
            set { SetValue(SubTitle1Property, value); }
        }

        // Using a DependencyProperty as the backing store for SubTitle1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SubTitle1Property =
            DependencyProperty.Register("SubTitle1", typeof(string), typeof(ccButton), new PropertyMetadata(string.Empty));


        public string SubTitle2
        {
            get { return (string)GetValue(SubTitle2Property); }
            set { SetValue(SubTitle2Property, value); }
        }

        // Using a DependencyProperty as the backing store for SubTitle2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SubTitle2Property =
            DependencyProperty.Register("SubTitle2", typeof(string), typeof(ccButton), new PropertyMetadata(string.Empty));



        public string SubTitle3
        {
            get { return (string)GetValue(SubTitle3Property); }
            set { SetValue(SubTitle3Property, value); }
        }

        // Using a DependencyProperty as the backing store for SubTitle3.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SubTitle3Property =
            DependencyProperty.Register("SubTitle3", typeof(string), typeof(ccButton), new PropertyMetadata(default));










        /// <summary>
        /// Title Button
        /// </summary>
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(ccButton), new PropertyMetadata(string.Empty));





        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Source.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(ImageSource), typeof(ccButton), new PropertyMetadata(default));




    }
}
