using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorApp
{
    public class CustomValidator:ComponentBase
    {
        private ValidationMessageStore messageStore;
        [CascadingParameter]
        private EditContext currentEditContext { get; set; }
        protected override void OnInitialized()
        {
            if (currentEditContext == null)
            {
                throw new InvalidOperationException($"{nameof(CustomValidator)} requires a cascading " +
                    $"parameter of type {nameof(EditContext)}. For example, you can use {nameof(CustomValidator)} " +
                    $"inside an EditForm.");
            }
            messageStore = new ValidationMessageStore(currentEditContext);
            currentEditContext.OnValidationRequested += (s, e) => messageStore.Clear();
            currentEditContext.OnFieldChanged += (s, e) => messageStore.Clear(e.FieldIdentifier);
        }

        public void DisplayErrors(Dictionary<string, List<string>> errors) 
        {
            foreach (var error in errors)
            {
                var fieldIdentifier = new FieldIdentifier(currentEditContext.Model, error.Key);
                messageStore.Add(fieldIdentifier, error.Value);
            }
        currentEditContext.NotifyValidationStateChanged();
        }

        public void ClearErrors()
        {
            messageStore.Clear();
            currentEditContext.NotifyValidationStateChanged();
        }
    }
}
