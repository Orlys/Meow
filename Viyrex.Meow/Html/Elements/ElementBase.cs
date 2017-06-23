using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using Viyrex.Meow.Html.Auxiliaries;
using System.Diagnostics;
namespace Viyrex.Meow.Html.Elements
{
   

    public abstract class ElementBase
    {
        public class DataAttribute : CollectionBase
        {
            public DataAttribute() : base()
            {

            }
        }

        [NotAttribute]
        public virtual string ElementContent { get; set; }

        [NotAttribute]
        public abstract ElementType ElementType { get; }

        [NotAttribute]
        public virtual string ElementName { get; set; }
        
        protected ElementBase()
        {
            this.ElementName = this.GetType().Name;
            this.Data = new DataAttribute();
        }

        public string ConvertToHtml()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<(string Key,string Value)> GetAttributes()
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
                    case CollectionBase cb:
                        foreach(var c in cb)
                            yield return c;
                        break;

                    case null:
                    default:
                        break;
                }
            }
            yield break;
        }

        [NotAttribute]
        public string this[string attributeName]
        {
            get
            {
                var n = attributeName.ToLower();
                if (new string(n.Take(5).ToArray()).Replace("_", "-") == "data-")
                    return this.Data[n];
                else
                    return this.GetType()
                                .GetRuntimeProperties()
                                .FirstOrDefault(x => x.GetCustomAttribute<NotAttributeAttribute>() == null
                                                    & x.Name.ToLower().Equals(n.Replace("-", "_")))?
                                .GetValue(this) as string;
            }
            set
            {
                var n = attributeName.ToLower();
                if (new string(n.Take(5).ToArray()).Replace("_","-") == "data-")
                    this.Data[n] = value;
                else
                    this.GetType()
                        .GetRuntimeProperties()
                        .FirstOrDefault(x => x.GetCustomAttribute<NotAttributeAttribute>() == null & x.Name.ToLower().Equals(n.Replace("-", "_")))?
                        .SetValue(this, value);
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
        #endregion

        #region Event Handler Atribute

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

        #endregion

        #endregion
    }
}