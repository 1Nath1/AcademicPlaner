using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Maui.Controls;

namespace AcademicPlaner.Behaviors
{
    public class NextEntryBehavior: Behavior<Entry>
    {
        public static readonly BindableProperty NextElementProperty = BindableProperty.Create(nameof(NextElement), typeof(VisualElement), typeof(NextEntryBehavior));

        public VisualElement NextElement
        {
            get => (VisualElement)GetValue(NextElementProperty);
            set => SetValue(NextElementProperty, value);
        }
        
        protected override void OnAttachedTo(Entry entry)
        {
            base.OnAttachedTo(entry);
            entry.Completed += OnCompleted;
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            base.OnDetachingFrom(entry);
            entry.Completed -= OnCompleted;
        }

        private void OnCompleted(object sender, EventArgs e)
        {
            NextElement?.Focus();
        }
    }
}
