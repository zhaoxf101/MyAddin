using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_SOA))]
#if Dev
    [RunLocal]
#endif

	public class EF_SOA:ReadOnlyBase<EF_SOA>
    {
        #region Business Methods

		
        public string BillCode
        {
            get ;
            set ;
        }

		
        public string BillName
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

		public static EF_SOA Create()
        {
            return EF.DataPortal.Create<EF_SOA>();
        }

		public static EF_SOA Fetch(System.Linq.Expressions.Expression<Func<EF_SOA, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_SOA>(exp,values);
            return EF.DataPortal.Fetch<EF_SOA>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_SOAs))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_SOAs:ReadOnlyListBase<EF_SOAs,EF_SOA>
    {
        #region Factory Methods

        public static EF_SOAs Fetch()
        {
            return EF.DataPortal.Fetch<EF_SOAs>();
        }

		public static EF_SOAs Fetch(System.Linq.Expressions.Expression<Func<EF_SOA, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_SOA>(exp,values);
            return EF.DataPortal.Fetch<EF_SOAs>(lambda);
		}

		public static EF_SOAs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_SOAs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_SOAs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_SOA, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_SOAs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_SOA>(exp,values)});
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
