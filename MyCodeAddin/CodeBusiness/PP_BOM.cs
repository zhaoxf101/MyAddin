using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PP_BOM))]
#if Dev
    [RunLocal]
#endif

	public class PP_BOM:ReadOnlyBase<PP_BOM>
    {
        #region Business Methods

		
        public string STLNR
        {
            get ;
            set ;
        }

		
        public string STLAL
        {
            get ;
            set ;
        }

		
        public string MaterialCode
        {
            get ;
            set ;
        }

		
        public string Plant
        {
            get ;
            set ;
        }

		
        public DateTime? UseDate
        {
            get ;
            set ;
        }

		
        public bool? IsDel
        {
            get ;
            set ;
        }

		
        public string UnitCode
        {
            get ;
            set ;
        }

		
        public decimal? BMENG
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
        public int? STLST
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PP_BOM Create()
        {
            return EF.DataPortal.Create<PP_BOM>();
        }

		public static PP_BOM Fetch(System.Linq.Expressions.Expression<Func<PP_BOM, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PP_BOM>(exp,values);
            return EF.DataPortal.Fetch<PP_BOM>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PP_BOMs))]
#if Dev
    [RunLocal]
#endif
	
	public class PP_BOMs:ReadOnlyListBase<PP_BOMs,PP_BOM>
    {
        #region Factory Methods

        public static PP_BOMs Fetch()
        {
            return EF.DataPortal.Fetch<PP_BOMs>();
        }

		public static PP_BOMs Fetch(System.Linq.Expressions.Expression<Func<PP_BOM, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PP_BOM>(exp,values);
            return EF.DataPortal.Fetch<PP_BOMs>(lambda);
		}

		public static PP_BOMs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PP_BOMs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PP_BOMs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PP_BOM, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PP_BOMs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PP_BOM>(exp,values)});
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
