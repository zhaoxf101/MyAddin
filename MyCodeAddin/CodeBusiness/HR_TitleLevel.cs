using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_TitleLevel))]
#if Dev
    [RunLocal]
#endif

	public class HR_TitleLevel:ReadOnlyBase<HR_TitleLevel>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TitleLevel
        {
            get ;
            set ;
        }

		
        public string TitleCode
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_TitleLevel Create()
        {
            return EF.DataPortal.Create<HR_TitleLevel>();
        }

		public static HR_TitleLevel Fetch(System.Linq.Expressions.Expression<Func<HR_TitleLevel, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_TitleLevel>(exp,values);
            return EF.DataPortal.Fetch<HR_TitleLevel>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_TitleLevels))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_TitleLevels:ReadOnlyListBase<HR_TitleLevels,HR_TitleLevel>
    {
        #region Factory Methods

        public static HR_TitleLevels Fetch()
        {
            return EF.DataPortal.Fetch<HR_TitleLevels>();
        }

		public static HR_TitleLevels Fetch(System.Linq.Expressions.Expression<Func<HR_TitleLevel, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_TitleLevel>(exp,values);
            return EF.DataPortal.Fetch<HR_TitleLevels>(lambda);
		}

		public static HR_TitleLevels Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_TitleLevels>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_TitleLevels Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_TitleLevel, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_TitleLevels>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_TitleLevel>(exp,values)});
        }

        #endregion

		[Serializable]
        public class Paging
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get 
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        [Serializable]
        public class PagigExpress
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            public LambdaExpression Lambda { get; set; }
        }

    }
}
