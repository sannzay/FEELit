using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage.Streams;
using Microsoft.ProjectOxford.Emotion;
using Microsoft.ProjectOxford.Emotion.Contract;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FEELit
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        CameraCaptureUI captureUI = new CameraCaptureUI();
        StorageFile photo;
        IRandomAccessStream imageStream;
        const String APIKEY = "d0cff6044bb84ea2acb9b648b92fada7";
        EmotionServiceClient emotionServiceClient = new EmotionServiceClient(APIKEY);
        Emotion[] emotionResult;
        public MainPage()
        {
            this.InitializeComponent();
            captureUI.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Jpeg;
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            int i, t;
            float min;
            try
            {
                photo = await captureUI.CaptureFileAsync(CameraCaptureUIMode.Photo);
                if (photo == null)
                {
                    return;
                }
                else
                {
                    imageStream = await photo.OpenAsync(FileAccessMode.Read);
                    emotionResult = await emotionServiceClient.RecognizeAsync(imageStream.AsStream());
                    if (emotionResult != null)
                    {
                        Scores score = emotionResult[0].Scores;
                        float[] a = new float[7] {score.Happiness, score.Sadness, score.Fear, score.Anger, score.Contempt, score.Disgust, score.Neutral };
                        t = 0;
                        min = 0;
                        i = 0;
                        while(i < 6) 
                        {
                            if (a[i] > min)
                            {
                                min = a[i];
                                t = i;
                            }
                            i++;
                        }
                        switch (t)
                        {
                            case 0:
                                BitmapImage happiness =
   new BitmapImage(new Uri("ms-appx:///Assets/happiness.jpg"));
                                image.Source = happiness;
                                break;
                            case 1:
                                BitmapImage sadness =
   new BitmapImage(new Uri("ms-appx:///Assets/sadness.jpg"));
                                image.Source = sadness;
                                break;
                            case 2:
                                BitmapImage fear =
   new BitmapImage(new Uri("ms-appx:///Assets/fear.jpg"));
                                image.Source = fear;
                                break;
                            case 3:
                                BitmapImage anger =
   new BitmapImage(new Uri("ms-appx:///Assets/angry.jpg"));
                                image.Source = anger;
                                break;
                            case 4:
                                BitmapImage contempt =
   new BitmapImage(new Uri("ms-appx:///Assets/contempt.jpg"));
                                image.Source = contempt;
                                break;
                            case 5:
                                BitmapImage disgust =
   new BitmapImage(new Uri("ms-appx:///Assets/disgust.jpg"));
                                image.Source = disgust;
                                break;
                            case 6:
                                BitmapImage neutral =
   new BitmapImage(new Uri("ms-appx:///Assets/neutral.png"));
                                image.Source = neutral;
                                break;

                        }
                    }
                }
            }
            catch
            {
                BitmapImage error = new BitmapImage(new Uri("ms-appx:///Assets/error.jpg"));
                image.Source = error;
            }
        }

        private void button23_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button20_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
