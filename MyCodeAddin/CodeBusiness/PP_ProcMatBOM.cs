using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PP_ProcMatBOM))]
#if Dev
    [RunLocal]
#endif

	public class PP_ProcMatBOM:ReadOnlyBase<PP_ProcMatBOM>
    {
        #region Business Methods

		
        public string PLNNR
        {
            get ;
            set ;
        }

		
        public string PLNAL
        {
            get ;
            set ;
        }

		
        public int ZUONR
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

		
        public bool? PARKZ
        {
            get ;
            set ;
        }

		
        public string PLNFL
        {
            get ;
            set ;
        }

		
        public int? PLNKN
        {
            get ;
            set ;
        }

		
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

		
        public string RGEKZ
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PP_ProcMatBOM Create()
        {
            return EF.DataPortal.Create<PP_ProcMatBOM>();
        }

		public static PP_ProcMatBOM Fetch(System.Linq.Expressions.Expression<Func<PP_ProcMatBOM, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PP_ProcMatBOM>(exp,values);
            return EF.DataPortal.Fetch<PP_ProcMatBOM>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PP_ProcMatBOMs))]
#if Dev
    [RunLocal]
#endif
	
	public class PP_ProcMatBOMs:ReadOnlyListBase<PP_ProcMatBOMs,PP_ProcMatBOM>
    {
        #region Factory Methods

        public static PP_ProcMatBOMs Fetch()
        {
            return EF.DataPortal.Fetch<PP_ProcMatBOMs>();
        }

		public static PP_ProcMatBOMs Fetch(System.Linq.Expressions.Expression<Func<PP_ProcMatBOM, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PP_ProcMatBOM>(exp,values);
            return EF.DataPortal.Fetch<PP_ProcMatBOMs>(lambda);
		}

		public static PP_ProcMatBOMs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PP_ProcMatBOMs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PP_ProcMatBOMs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PP_ProcMatBOM, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PP_ProcMatBOMs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PP_ProcMatBOM>(exp,values)});
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
