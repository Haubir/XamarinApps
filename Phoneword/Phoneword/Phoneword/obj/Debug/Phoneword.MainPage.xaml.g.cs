// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Phoneword {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("/Users/Haubir/XamarinProjects/Phoneword/Phoneword/Phoneword/MainPage.xaml")]
    public partial class MainPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry phoneNumberText;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Button translateButon;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Button callButton;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(MainPage));
            phoneNumberText = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.Entry>(this, "phoneNumberText");
            translateButon = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.Button>(this, "translateButon");
            callButton = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.Button>(this, "callButton");
        }
    }
}
