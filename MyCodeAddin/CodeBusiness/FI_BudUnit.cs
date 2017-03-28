using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BudUnit))]
#if Dev
    [RunLocal]
#endif

	public class FI_BudUnit:ReadOnlyBase<FI_BudUnit>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BudUnitCode
        {
            get ;
            set ;
        }

		
        public string BudUnitName
        {
            get ;
            set ;
        }

		
        public int FirYear
        {
            get ;
            set ;
        }

		
        public int EndYear
        {
            get ;
            set ;
        }

		
        public int BudYear
        {
            get ;
            set ;
        }

		
        public int AccYear
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

		public static FI_BudUnit Create()
        {
            return EF.DataPortal.Create<FI_BudUnit>();
        }

		public static FI_BudUnit Fetch(System.Linq.Expressions.Expression<Func<FI_BudUnit, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BudUnit>(exp,values);
            return EF.DataPortal.Fetch<FI_BudUnit>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BudUnits))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BudUnits:ReadOnlyListBase<FI_BudUnits,FI_BudUnit>
    {
        #region Factory Methods

        public static FI_BudUnits Fetch()
        {
            return EF.DataPortal.Fetch<FI_BudUnits>();
        }

		public static FI_BudUnits Fetch(System.Linq.Expressions.Expression<Func<FI_BudUnit, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BudUnit>(exp,values);
            return EF.DataPortal.Fetch<FI_BudUnits>(lambda);
		}

		public static FI_BudUnits Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BudUnits>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BudUnits Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BudUnit, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BudUnits>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BudUnit>(exp,values)});
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
