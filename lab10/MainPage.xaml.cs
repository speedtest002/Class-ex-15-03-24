using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace lab10
{
   /// <summary>
   /// An empty page that can be used on its own or navigated to within a Frame.
   /// </summary>
   public sealed partial class MainPage : Page
   {
      DispatcherTimer timer = new DispatcherTimer(); //Tạo biến timer
      int tenthsOfSecondsElapsed; //Tạo biến đếm thời gian 1/10 giây
      int matchesFound; //Số cặp được trùng khớp
      float highestScore = 99999999;
      public MainPage()
      {
         this.InitializeComponent();
         randomAnimalList = Enumerable.Repeat("?", 16).ToList();
         timer.Interval = TimeSpan.FromSeconds(.1);
         timer.Tick += Timer_Tick;
         //SetUpGame();
      }

      private void Timer_Tick(object sender, object e)
      {
         tenthsOfSecondsElapsed++;
         timeTextBlock.Text = (tenthsOfSecondsElapsed / 10F).ToString("0.0s");
         if (matchesFound == 8)
         {
            randomAnimalList = Enumerable.Repeat("?", 16).ToList();
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
               textBlock.Text = "?";
            }
            timer.Stop();
            if (highestScore > tenthsOfSecondsElapsed)
            {
               highestScore = tenthsOfSecondsElapsed;
               highestScoreTextBlock.Text = (highestScore / 10F).ToString("0.0s");
            }
            timeTextBlock.Text = timeTextBlock.Text + " - Play again?";
         }
      }

      List<string> randomAnimalList = new List<string>();
      private void SetUpGame()
      {
         List<string> animalEmoiji = new List<string>()
               {
                   "😺", "😺",
                   "😸", "😸",
                   "😹", "😹",
                   "😻", "😻",
                   "😼", "😼",
                   "😽", "😽",
                   "🙀", "🙀",
                   "😿", "😿",
               };

         Random random = new Random(); //Tạo biến random

         randomAnimalList.Clear(); //Xóa list randomAnimalList
         foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
         {
            int index = random.Next(animalEmoiji.Count); //Tạo giá trị ngẫu nhiên 0 - kích thước của list
            string nextEmoiji = animalEmoiji[index]; //Tạo emoiji ngẫu nhiên từ list với index
            //textBlock.Text = nextEmoiji; //Gán Emoij cho textBlock
            randomAnimalList.Add(nextEmoiji); //Thêm emoiji vào list randomAnimalList
            animalEmoiji.RemoveAt(index); //Xóa phần tử vừa gán
            textBlock.Visibility = Visibility.Visible;
         }
         timer.Start();
         tenthsOfSecondsElapsed = 0;
         matchesFound = 0;
         pointTextBlock.Text = matchesFound.ToString();
      }

      TextBlock lastTextBlockClicked;
      string lastClick;
      bool findingMatch = false;
      //private async void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
      private bool canClick = true;
      private bool gameStartButtonClicked = false;

      private async void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
      {
         if (canClick && gameStartButtonClicked)
         {
            canClick = false;
            TextBlock textBlock = sender as TextBlock;
            if (!findingMatch)
            {
               lastClick = randomAnimalList[Grid.GetColumn(textBlock) + Grid.GetRow(textBlock) * 4];
               textBlock.Text = lastClick;
               lastTextBlockClicked = textBlock;
               findingMatch = true;
            }
            else if (randomAnimalList[Grid.GetColumn(textBlock) + Grid.GetRow(textBlock) * 4] == lastClick && textBlock != lastTextBlockClicked)
            {
               textBlock.Text = randomAnimalList[Grid.GetColumn(textBlock) + Grid.GetRow(textBlock) * 4];
               await Task.Delay(500);
               textBlock.Visibility = Visibility.Collapsed;
               lastTextBlockClicked.Visibility = Visibility.Collapsed;
               findingMatch = false;
               matchesFound++;
               pointTextBlock.Text = matchesFound.ToString();
            }
            else
            {
               textBlock.Text = randomAnimalList[Grid.GetColumn(textBlock) + Grid.GetRow(textBlock) * 4];
               await Task.Delay(500);
               lastTextBlockClicked.Text = "?";
               textBlock.Text = "?";
               findingMatch = false;
            }
            await Task.Delay(100);
            canClick = true;
         }
      }
      private void TimeTextBlock_Tapped(object sender, TappedRoutedEventArgs e)
      {
         if (matchesFound == 8 || matchesFound == 0)
         {
            gameStartButtonClicked = true;
            SetUpGame();
         }
      }
   }
}