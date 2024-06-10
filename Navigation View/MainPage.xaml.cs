using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Navigation_View
{
   /// <summary>
   /// An empty page that can be used on its own or navigated to within a Frame.
   /// </summary>
   public sealed partial class MainPage : Page
   {
      public MainPage()
      {
         InitializeComponent();
         ContentFrame.Navigate(typeof(HomePage));
         MyNavigationView.SelectedItem = HomeItem;

      }
   
      public void MyNavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
      {
         FrameNavigationOptions navigationOptions = new FrameNavigationOptions();
         navigationOptions.TransitionInfoOverride = args.RecommendedNavigationTransitionInfo;
         var selectedItem = MyNavigationView.SelectedItem;

         if (selectedItem == HomeItem)
         {
            ContentFrame.Navigate(typeof(HomePage));
         }
         else if (selectedItem == AddFriendItem)
         {
            ContentFrame.Navigate(typeof(AddFriendPage));
         }
         else if (selectedItem == ContactInfoItem)
         {
            ContentFrame.Navigate(typeof(ContactInfoPage));
         }
      }

      private void MyNavigationView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
      {
         if (ContentFrame.CanGoBack)
         {
            MyNavigationView.IsBackEnabled = true;
            ContentFrame.GoBack();

            if (ContentFrame.SourcePageType == typeof(HomePage))
            {
               MyNavigationView.SelectedItem = HomeItem;
            }
            else if (ContentFrame.SourcePageType == typeof(AddFriendPage))
            {
               MyNavigationView.SelectedItem = AddFriendItem;
            }
            else if (ContentFrame.SourcePageType == typeof(ContactInfoPage))
            {
               MyNavigationView.SelectedItem = ContactInfoItem;
            }
         }
      }
   }
}