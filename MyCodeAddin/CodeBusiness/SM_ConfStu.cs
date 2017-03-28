using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_ConfStu))]
#if Dev
    [RunLocal]
#endif

	public class SM_ConfStu:ReadOnlyBase<SM_ConfStu>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ConfCode
        {
            get ;
            set ;
        }

		
        public string StudentNo
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_ConfStu Create()
        {
            return EF.DataPortal.Create<SM_ConfStu>();
        }

		public static SM_ConfStu Fetch(System.Linq.Expressions.Expression<Func<SM_ConfStu, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_ConfStu>(exp,values);
            return EF.DataPortal.Fetch<SM_ConfStu>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_ConfStus))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_ConfStus:ReadOnlyListBase<SM_ConfStus,SM_ConfStu>
    {
        #region Factory Methods

        public static SM_ConfStus Fetch()
        {
            return EF.DataPortal.Fetch<SM_ConfStus>();
        }

		public static SM_ConfStus Fetch(System.Linq.Expressions.Expression<Func<SM_ConfStu, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_ConfStu>(exp,values);
            return EF.DataPortal.Fetch<SM_ConfStus>(lambda);
		}

		public static SM_ConfStus Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_ConfStus>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_ConfStus Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_ConfStu, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_ConfStus>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_ConfStu>(exp,values)});
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
