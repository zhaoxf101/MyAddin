using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_Tables))]
#if Dev
    [RunLocal]
#endif

	public class EF_Tables:ReadOnlyBase<EF_Tables>
    {
        #region Business Methods

		
        public string TableName
        {
            get ;
            set ;
        }

		
        public string Active
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

		
        public string MainFlag
        {
            get ;
            set ;
        }

		
        public string ConFlag
        {
            get ;
            set ;
        }

		
        public string LastUser
        {
            get ;
            set ;
        }

		
        public DateTime? LastDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_Tables Create()
        {
            return EF.DataPortal.Create<EF_Tables>();
        }

		public static EF_Tables Fetch(System.Linq.Expressions.Expression<Func<EF_Tables, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_Tables>(exp,values);
            return EF.DataPortal.Fetch<EF_Tables>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_Tabless))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_Tabless:ReadOnlyListBase<EF_Tabless,EF_Tables>
    {
        #region Factory Methods

        public static EF_Tabless Fetch()
        {
            return EF.DataPortal.Fetch<EF_Tabless>();
        }

		public static EF_Tabless Fetch(System.Linq.Expressions.Expression<Func<EF_Tables, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_Tables>(exp,values);
            return EF.DataPortal.Fetch<EF_Tabless>(lambda);
		}

		public static EF_Tabless Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_Tabless>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_Tabless Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_Tables, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_Tabless>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_Tables>(exp,values)});
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
