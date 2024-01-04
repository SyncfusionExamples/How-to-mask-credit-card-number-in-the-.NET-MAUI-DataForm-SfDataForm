using Syncfusion.Maui.DataForm;

namespace MaskCreditCardNumber;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        dataForm.GenerateDataFormItem += OnGenerateDataFormItem;
    }
    private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    {
        if (e.DataFormItem != null)
        {
            if (e.DataFormItem.FieldName == "CardNumber")
            {
                var maskedItem = e.DataFormItem as DataFormMaskedTextItem;
                maskedItem.Mask = "0000-0000-0000-0000";
                maskedItem.PromptChar = 'X';
                maskedItem.Keyboard = Keyboard.Numeric;
            }
        }
    }
}