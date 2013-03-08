using System;
using System.Collections.Generic;

namespace Testing.Framework.Browser.PageModel
{
    public class NonExistentElement : IHtmlElement
    {
        private readonly string _cssSelector;

        public NonExistentElement(string cssSelector)
        {
            _cssSelector = cssSelector;
        }

        public bool Exists
        {
            get { return false; }
        }

        public bool Visible
        {
            get { return false; }
        }

        public string Text
        {
            get { throw ElementDoesNotExistsException(); }
        }

        public void Click()
        {
            throw ElementDoesNotExistsException();
        }

        public void Type(string text)
        {
            throw ElementDoesNotExistsException();
        }

        public IHtmlElement GetElement(string cssSelector)
        {
            throw ElementDoesNotExistsException();
        }

        public IEnumerable<IHtmlElement> GetElements(string cssSelector)
        {
            throw ElementDoesNotExistsException();
        }

        private Exception ElementDoesNotExistsException()
        {
            return new Exception(string.Format("The element \'{0}\' does not exists.", _cssSelector));
        }
    }
}
