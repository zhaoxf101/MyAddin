using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_TCView))]
#if Dev
    [RunLocal]
#endif

	public class EF_TCView:ReadOnlyBase<EF_TCView>
    {
        #region Business Methods

		
        public string Program
        {
            get ;
            set ;
        }

		
        public string UserType
        {
            get ;
            set ;
        }

		
        public string TCUser
        {
            get ;
            set ;
        }

		
        public string TCControl
        {
            get ;
            set ;
        }

		
        public string TCVersion
        {
            get ;
            set ;
        }

		
        public int FieldPos
        {
            get ;
            set ;
        }

		
        public string FieldName
        {
            get ;
            set ;
        }

		
        public int? FieldLen
        {
            get ;
            set ;
        }

		
        public int? FixCols
        {
            get ;
            set ;
        }

		
        public int? LineSel
        {
            get ;
            set ;
        }

		
        public int? ColSel
        {
            get ;
            set ;
        }

		
        public string TCH_Grid
        {
            get ;
            set ;
        }

		
        public string TCV_Grid
        {
            get ;
            set ;
        }

		
        public string Invisible
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_TCView Create()
        {
            return EF.DataPortal.Create<EF_TCView>();
        }

		public static EF_TCView Fetch(System.Linq.Expressions.Expression<Func<EF_TCView, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_TCView>(exp,values);
            return EF.DataPortal.Fetch<EF_TCView>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_TCViews))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_TCViews:ReadOnlyListBase<EF_TCViews,EF_TCView>
    {
        #region Factory Methods

        public static EF_TCViews Fetch()
        {
            return EF.DataPortal.Fetch<EF_TCViews>();
        }

		public static EF_TCViews Fetch(System.Linq.Expressions.Expression<Func<EF_TCView, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_TCView>(exp,values);
            return EF.DataPortal.Fetch<EF_TCViews>(lambda);
		}

		public static EF_TCViews Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_TCViews>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_TCViews Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_TCView, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_TCViews>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_TCView>(exp,values)});
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
