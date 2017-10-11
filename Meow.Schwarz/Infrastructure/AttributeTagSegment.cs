// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz.Infrastructure
{
    using Interface;

    public abstract class AttributeTagSegment : TagSegment, IAttributeSegment
    {
        #region Internal Constructors

        internal AttributeTagSegment(int start, int stop, string source, Attributes attributes)
            : this(start, stop, source, default, attributes)
        {
        }

        internal AttributeTagSegment(int start, int stop, string source)
            : this(start, stop, source, default, default(string))
        {
        }

        internal AttributeTagSegment(int start, int stop, string source, string tagName)
            : this(start, stop, source, tagName, default(string))
        {
        }

        internal AttributeTagSegment(int start, int stop, string source, string tagName, string attributesString)
            : this(start, stop, source, tagName, attributesString is default ? new Attributes() : Attributes.Resolve(attributesString))
        {
        }

        internal AttributeTagSegment(int start, int stop, string source, string tagName, Attributes attributes)
            : base(start, stop, source, tagName)
        {
            this.Attributes = attributes ?? new Attributes();
        }

        #endregion Internal Constructors

        #region Public Properties

        public string AccessKey
        {
            get => this.Attributes[nameof(AccessKey)];
            set => this.Attributes[nameof(AccessKey)] = value;
        }

        public Attributes Attributes { get; internal set; }

        public string Class
        {
            get => this.Attributes[nameof(Class)];
            set => this.Attributes[nameof(Class)] = value;
        }

        public string ContentEditable
        {
            get => this.Attributes[nameof(ContentEditable)];
            set => this.Attributes[nameof(ContentEditable)] = value;
        }

        public string ContextMenu
        {
            get => this.Attributes[nameof(ContextMenu)];
            set => this.Attributes[nameof(ContextMenu)] = value;
        }

        public Data Data
                                                    => this.Attributes.Data;

        public string Dir
        {
            get => this.Attributes[nameof(Dir)];
            set => this.Attributes[nameof(Dir)] = value;
        }

        public string Draggable
        {
            get => this.Attributes[nameof(Draggable)];
            set => this.Attributes[nameof(Draggable)] = value;
        }

        public string DropZone
        {
            get => this.Attributes[nameof(DropZone)];
            set => this.Attributes[nameof(DropZone)] = value;
        }

        public string Hidden
        {
            get => this.Attributes[nameof(Hidden)];
            set => this.Attributes[nameof(Hidden)] = value;
        }

        public string Id
        {
            get => this.Attributes[nameof(Id)];
            set => this.Attributes[nameof(Id)] = value;
        }

        public string ItemId
        {
            get => this.Attributes[nameof(ItemId)];
            set => this.Attributes[nameof(ItemId)] = value;
        }

        public string ItemProp
        {
            get => this.Attributes[nameof(ItemProp)];
            set => this.Attributes[nameof(ItemProp)] = value;
        }

        public string ItemRef
        {
            get => this.Attributes[nameof(ItemRef)];
            set => this.Attributes[nameof(ItemRef)] = value;
        }

        public string ItemScope
        {
            get => this.Attributes[nameof(ItemScope)];
            set => this.Attributes[nameof(ItemScope)] = value;
        }

        public string ItemType
        {
            get => this.Attributes[nameof(ItemType)];
            set => this.Attributes[nameof(ItemType)] = value;
        }

        public string Lang
        {
            get => this.Attributes[nameof(Lang)];
            set => this.Attributes[nameof(Lang)] = value;
        }

        public string Slot
        {
            get => this.Attributes[nameof(Slot)];
            set => this.Attributes[nameof(Slot)] = value;
        }

        public string Spellcheck
        {
            get => this.Attributes[nameof(Spellcheck)];
            set => this.Attributes[nameof(Spellcheck)] = value;
        }

        public string Style
        {
            get => this.Attributes[nameof(Style)];
            set => this.Attributes[nameof(Style)] = value;
        }

        public string TabIndex
        {
            get => this.Attributes[nameof(TabIndex)];
            set => this.Attributes[nameof(TabIndex)] = value;
        }

        public string Title
        {
            get => this.Attributes[nameof(Title)];
            set => this.Attributes[nameof(Title)] = value;
        }

        public string Translate
        {
            get => this.Attributes[nameof(Translate)];
            set => this.Attributes[nameof(Translate)] = value;
        }

        #endregion Public Properties

        #region Public Methods

        public override abstract string TextLayout();

        #endregion Public Methods
    }
}