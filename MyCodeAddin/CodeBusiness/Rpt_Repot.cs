using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Rpt_Repot))]
#if Dev
    [RunLocal]
#endif

	public class Rpt_Repot:ReadOnlyBase<Rpt_Repot>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string RepotCode
        {
            get ;
            set ;
        }

		
        public string ReportName
        {
            get ;
            set ;
        }

		
        public string ReportType
        {
            get ;
            set ;
        }

		
        public string ReportFile
        {
            get ;
            set ;
        }

		
        public bool IsYear
        {
            get ;
            set ;
        }

		
        public bool IsMonth
        {
            get ;
            set ;
        }

		
        public bool IsDay
        {
            get ;
            set ;
        }

		
        public string BookType
        {
            get ;
            set ;
        }

		
        public int Sort
        {
            get ;
            set ;
        }

		
        public bool IsLandscape
        {
            get ;
            set ;
        }

		
        public string PageWidth
        {
            get ;
            set ;
        }

		
        public string PageHeight
        {
            get ;
            set ;
        }

		
        public string PageTop
        {
            get ;
            set ;
        }

		
        public string PageLeft
        {
            get ;
            set ;
        }

		
        public string PageRight
        {
            get ;
            set ;
        }

		
        public string PageBottom
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Rpt_Repot Create()
        {
            return EF.DataPortal.Create<Rpt_Repot>();
        }

		public static Rpt_Repot Fetch(System.Linq.Expressions.Expression<Func<Rpt_Repot, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Rpt_Repot>(exp,values);
            return EF.DataPortal.Fetch<Rpt_Repot>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Rpt_Repots))]
#if Dev
    [RunLocal]
#endif
	
	public class Rpt_Repots:ReadOnlyListBase<Rpt_Repots,Rpt_Repot>
    {
        #region Factory Methods

        public static Rpt_Repots Fetch()
        {
            return EF.DataPortal.Fetch<Rpt_Repots>();
        }

		public static Rpt_Repots Fetch(System.Linq.Expressions.Expression<Func<Rpt_Repot, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Rpt_Repot>(exp,values);
            return EF.DataPortal.Fetch<Rpt_Repots>(lambda);
		}

		public static Rpt_Repots Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Rpt_Repots>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Rpt_Repots Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Rpt_Repot, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Rpt_Repots>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Rpt_Repot>(exp,values)});
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
