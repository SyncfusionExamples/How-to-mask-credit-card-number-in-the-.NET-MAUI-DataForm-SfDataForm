using Syncfusion.Maui.DataForm;

namespace MaskCreditCardNumber
{
    public class DataFormBehavior : Behavior<ContentPage>
    {
        private SfDataForm dataForm;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            this.dataForm = bindable.FindByName<SfDataForm>("dataForm");
            this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;    
        }
        private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
        {
            if(e.DataFormItem != null)
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
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            if (this.dataForm != null)
            {
                this.dataForm.GenerateDataFormItem -= OnGenerateDataFormItem;
                this.dataForm = null;
            }
        }
    }
}