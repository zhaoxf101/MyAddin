using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_Title))]
#if Dev
    [RunLocal]
#endif

	public class HR_Title:ReadOnlyBase<HR_Title>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TitleCode
        {
            get ;
            set ;
        }

		
        public string TitleName
        {
            get ;
            set ;
        }

		
        public string TitleLevel
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_Title Create()
        {
            return EF.DataPortal.Create<HR_Title>();
        }

		public static HR_Title Fetch(System.Linq.Expressions.Expression<Func<HR_Title, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_Title>(exp,values);
            return EF.DataPortal.Fetch<HR_Title>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_Titles))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_Titles:ReadOnlyListBase<HR_Titles,HR_Title>
    {
        #region Factory Methods

        public static HR_Titles Fetch()
        {
            return EF.DataPortal.Fetch<HR_Titles>();
        }

		public static HR_Titles Fetch(System.Linq.Expressions.Expression<Func<HR_Title, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_Title>(exp,values);
            return EF.DataPortal.Fetch<HR_Titles>(lambda);
		}

		public static HR_Titles Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_Titles>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_Titles Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_Title, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_Titles>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_Title>(exp,values)});
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
