using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_BudAreaPara))]
#if Dev
    [RunLocal]
#endif

	public class Sys_BudAreaPara:ReadOnlyBase<Sys_BudAreaPara>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string FundBudAreaCode
        {
            get ;
            set ;
        }

		
        public int BudYear
        {
            get ;
            set ;
        }

		
        public bool IsOpen
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

		public static Sys_BudAreaPara Create()
        {
            return EF.DataPortal.Create<Sys_BudAreaPara>();
        }

		public static Sys_BudAreaPara Fetch(System.Linq.Expressions.Expression<Func<Sys_BudAreaPara, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_BudAreaPara>(exp,values);
            return EF.DataPortal.Fetch<Sys_BudAreaPara>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_BudAreaParas))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_BudAreaParas:ReadOnlyListBase<Sys_BudAreaParas,Sys_BudAreaPara>
    {
        #region Factory Methods

        public static Sys_BudAreaParas Fetch()
        {
            return EF.DataPortal.Fetch<Sys_BudAreaParas>();
        }

		public static Sys_BudAreaParas Fetch(System.Linq.Expressions.Expression<Func<Sys_BudAreaPara, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_BudAreaPara>(exp,values);
            return EF.DataPortal.Fetch<Sys_BudAreaParas>(lambda);
		}

		public static Sys_BudAreaParas Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_BudAreaParas>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_BudAreaParas Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_BudAreaPara, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_BudAreaParas>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_BudAreaPara>(exp,values)});
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
