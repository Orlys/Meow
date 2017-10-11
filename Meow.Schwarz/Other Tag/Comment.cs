// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D
namespace Meow.Schwarz
{
    using Auxiliary;
    using Infrastructure;
    using Interface;

    [Preprocess(int.MaxValue - 1)]
    public sealed class Comment : ParticularTagSegment
    {
        #region Internal Constructors

        internal Comment(int start, int stop, string source) : base(start, stop, source)
        {
        }

        #endregion Internal Constructors

        #region Public Properties

        public override string TagName => nameof(Comment);

        #endregion Public Properties

        #region Public Methods

        public static bool Preprocess(string html, ref int index, out ISegment segment)
        {
            segment = default(ISegment);
            if (html[index + 1] == '!' &&
                html[index + 2] == '-' &&
                html[index + 3] == '-')
            {
                int startIndex = index;
                index += 4;
                for (; index < html.Length; index++)
                {
                    if (html[index] == '>' &&
                        html[index - 1] == '-' &&
                        html[index - 2] == '-')
                    {
                        segment = new Comment(startIndex, index, html);
                        break;
                    }
                }
                return true;
            }

            //
            return false;
        }

        #endregion Public Methods

        #region Protected Methods

        protected override string BlockEvaluate(string block)
                            => block.TrimStart("<!--".ToCharArray()).TrimEnd("-->".ToCharArray());

        #endregion Protected Methods

        /*

        //Obsolete CODE

        static bool ProcessComment(string html, ref int index, out ISegment segment)
        {
            segment = default(ISegment);

            //process <!--Comment-->
            if (html[index + 1] == '!' &&
                html[index + 2] == '-' &&
                html[index + 3] == '-')
            {
                int startIndex = index;
                index += 4;
                for (; index < html.Length; index++)
                {
                    if (html[index] == '>' &&
                        html[index - 1] == '-' &&
                        html[index - 2] == '-')
                    {
                        segment = new TagSegment(startIndex, index, html, "Comment");
                        index--;
                        break;
                    }
                }
                return true;
            }

            //
            return false;
        }
         */
    }
}