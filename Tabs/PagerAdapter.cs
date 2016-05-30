using System;
using Android.Support.V4.App;
using Java.Lang;

namespace Tabs
{
    public class PagerAdapter:FragmentPagerAdapter
    {
        private string[] Titles;

        public PagerAdapter(FragmentManager fm, string[] titles)
            : base(fm)
        {
            Titles = titles;
        }

        public override ICharSequence GetPageTitleFormatted(int position)
        {

            return new Java.Lang.String(Titles[position]);
        }

        public override int Count
        {
            get { return Titles.Length; }
        }

        public override Fragment GetItem(int position)
        {
            switch (position)
            {
                case 0:
                    return new Fragment1();
                case 1:
                    return new Fragment2();
                case 2:
                default:
                    return new Fragment1();
            }
        }
    }
}

