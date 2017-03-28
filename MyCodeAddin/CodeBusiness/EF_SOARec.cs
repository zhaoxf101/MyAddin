using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_SOARec))]
#if Dev
    [RunLocal]
#endif

	public class EF_SOARec:ReadOnlyBase<EF_SOARec>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string BillCode
        {
            get ;
            set ;
        }

		
        public string BillDate
        {
            get ;
            set ;
        }

		
        public bool SuccX
        {
            get ;
            set ;
        }

		
        public string Msg
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public string CreateUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreateDate
        {
            get ;
            set ;
        }

		
        public string ChangeUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangeDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_SOARec Create()
        {
            return EF.DataPortal.Create<EF_SOARec>();
        }

		public static EF_SOARec Fetch(System.Linq.Expressions.Expression<Func<EF_SOARec, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_SOARec>(exp,values);
            return EF.DataPortal.Fetch<EF_SOARec>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_SOARecs))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_SOARecs:ReadOnlyListBase<EF_SOARecs,EF_SOARec>
    {
        #region Factory Methods

        public static EF_SOARecs Fetch()
        {
            return EF.DataPortal.Fetch<EF_SOARecs>();
        }

		public static EF_SOARecs Fetch(System.Linq.Expressions.Expression<Func<EF_SOARec, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_SOARec>(exp,values);
            return EF.DataPortal.Fetch<EF_SOARecs>(lambda);
		}

		public static EF_SOARecs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_SOARecs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_SOARecs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_SOARec, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_SOARecs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_SOARec>(exp,values)});
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
