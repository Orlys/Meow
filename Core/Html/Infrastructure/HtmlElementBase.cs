namespace Meow.Html.Infrastructure
{
    using Meow.Auxiliary;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public abstract class HtmlElementBase : ElementBase
    {
        protected HtmlElementBase()
        {
            this.Data = new DataAttribute();
        }

        [NotAttribute]
        public override string this[string attributeName]
        {
            get
            {
                var n = attributeName.ToLower();
                if (n.Length > 5 && n.Substring(0, 5).Replace("_", "-") == "data-")
                    return this.Data[n];
                else
                    return base[attributeName];
            }
            set
            {
                var n = attributeName.ToLower();
                if (n.Length > 5 && n.Substring(0, 5).Replace("_", "-") == "data-")
                    this.Data[n] = value;
                else
                    base[attributeName] = value;
            }
        }

        public override IEnumerable<(string Key, string Value)> GetAttributes()
        {
            foreach (var prop in this.GetType()
                                        .GetRuntimeProperties()
                                        .Where(x => x.GetCustomAttribute<NotAttributeAttribute>() == null))
            {
                var value = prop.GetValue(this);
                switch (value)
                {
                    case string s:
                        yield return (prop.Name, value.ToString());
                        break;

                    case DataAttribute da:
                        foreach (var a in da)
                            yield return a;
                        break;

                    case null:
                    default:

                        break;
                }
            }
            yield break;
        }

        /// <summary>
        /// Data-* attributes
        /// </summary>
        public sealed class DataAttribute : IEnumerable<(string Key, string Value)>
        {
            private readonly Dictionary<string, string> dict;

            internal DataAttribute()
            => this.dict = new Dictionary<string, string>();

            public string this[string attribute]
            {
                get
                    => this.dict.TryGetValue(PreprocessKey(attribute), out var v) ? v : string.Empty;
                set
                    => this.dict[PreprocessKey(attribute)] = value;
            }

            public IEnumerator<(string Key, string Value)> GetEnumerator()
                => this.dict.Select(x => ("Data-" + x.Key, x.Value)).GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator()
                => this.GetEnumerator();

            private string PreprocessKey(string attribute)
            {
                var a = attribute.ToLower().TrimStart('-', '_');
                return (a.Length > 4 && a.Substring(0, 5).SequenceEqual("data-")) ? a.Substring(5) : a;
            }
        }

        #region Global Attribute

        #region Core Attribute

        public virtual string AccessKey { get; set; }

        public virtual string Class { get; set; }

        public virtual string ContentEditable { get; set; }

        public virtual string ContextMenu { get; set; }

        public virtual DataAttribute Data { get; set; }

        public virtual string Dir { get; set; }

        public virtual string Draggable { get; set; }

        [Experimental]
        public virtual string DropZone { get; set; }

        public virtual string Hidden { get; set; }

        public virtual string Id { get; set; }

        [Experimental]
        public virtual string ItemId { get; set; }

        [Experimental]
        public virtual string ItemProp { get; set; }

        [Experimental]
        public virtual string ItemRef { get; set; }

        [Experimental]
        public virtual string ItemScope { get; set; }

        [Experimental]
        public virtual string ItemType { get; set; }

        public virtual string Lang { get; set; }

        [Experimental]
        public virtual string Slot { get; set; }

        [Experimental]
        public virtual string Spellcheck { get; set; }

        public virtual string Style { get; set; }

        public virtual string TabIndex { get; set; }

        public virtual string Title { get; set; }

        public virtual string Translate { get; set; }

        #endregion Core Attribute

#if SUPPPRT_EVENT_HANDLER_ATTRIBUTES

        #region Event Handler Atributes

        public string OnAbort { get; set; }

        public string OnBlur { get; set; }

        public string OnCanPlay { get; set; }

        public string OnCanPlayThrough { get; set; }

        public string OnChange { get; set; }

        public string OnClick { get; set; }

        public string OnContextMenu { get; set; }

        public string OnDblClick { get; set; }

        public string OnDrag { get; set; }

        public string OnDragEnd { get; set; }

        public string OnDragEnter { get; set; }

        public string OnDragLeave { get; set; }

        public string OnDragOver { get; set; }

        public string OnDragStart { get; set; }

        public string OnDrop { get; set; }

        public string OnDurationChange { get; set; }

        public string OnEmptied { get; set; }

        public string OnEnded { get; set; }

        public string OnError { get; set; }

        public string OnFocus { get; set; }

        public string OnFormChange { get; set; }

        public string OnFormInput { get; set; }

        public string OnInput { get; set; }

        public string OnInvaild { get; set; }

        public string OnKeyDown { get; set; }

        public string OnKeyPress { get; set; }

        public string OnKeyUp { get; set; }

        public string OnLoad { get; set; }

        public string OnLoadedData { get; set; }

        public string OnLoadedMetadata { get; set; }

        public string OnLoadStart { get; set; }

        public string OnMouseDown { get; set; }

        public string OnMouseMove { get; set; }

        public string OnMouseOut { get; set; }

        public string OnMouseOver { get; set; }

        public string OnMouseUp { get; set; }

        public string OnMouseWheel { get; set; }

        public string OnPause { get; set; }

        public string OnPlay { get; set; }

        public string OnPlaying { get; set; }

        public string OnProgress { get; set; }

        public string OnRateChange { get; set; }

        public string OnReadyStateChange { get; set; }

        public string OnScroll { get; set; }

        public string OnSeeked { get; set; }

        public string OnSeeking { get; set; }

        public string OnSelect { get; set; }

        public string OnShow { get; set; }

        public string OnStalled { get; set; }

        public string OnSubmit { get; set; }

        public string OnSuspend { get; set; }

        public string OnTimeUpdate { get; set; }

        public string OnVolumeChange { get; set; }

        public string OnWaiting { get; set; }

        #endregion Event Handler Atributes

#endif

        #endregion Global Attribute
    }
}