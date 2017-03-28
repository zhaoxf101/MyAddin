using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_Tables_N))]
#if Dev
    [RunLocal]
#endif

	public class EF_Tables_N:ReadOnlyBase<EF_Tables_N>
    {
        #region Business Methods

		
        public string TableName
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string TabClass
        {
            get ;
            set ;
        }

		
        public string Category
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

		public static EF_Tables_N Create()
        {
            return EF.DataPortal.Create<EF_Tables_N>();
        }

		public static EF_Tables_N Fetch(System.Linq.Expressions.Expression<Func<EF_Tables_N, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_Tables_N>(exp,values);
            return EF.DataPortal.Fetch<EF_Tables_N>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_Tables_Ns))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_Tables_Ns:ReadOnlyListBase<EF_Tables_Ns,EF_Tables_N>
    {
        #region Factory Methods

        public static EF_Tables_Ns Fetch()
        {
            return EF.DataPortal.Fetch<EF_Tables_Ns>();
        }

		public static EF_Tables_Ns Fetch(System.Linq.Expressions.Expression<Func<EF_Tables_N, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_Tables_N>(exp,values);
            return EF.DataPortal.Fetch<EF_Tables_Ns>(lambda);
		}

		public static EF_Tables_Ns Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_Tables_Ns>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_Tables_Ns Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_Tables_N, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_Tables_Ns>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_Tables_N>(exp,values)});
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
