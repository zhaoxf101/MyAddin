using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_Position))]
#if Dev
    [RunLocal]
#endif

	public class HR_Position:ReadOnlyBase<HR_Position>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string PositionCode
        {
            get ;
            set ;
        }

		
        public string PositionName
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string JobCode
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsDel
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

		public static HR_Position Create()
        {
            return EF.DataPortal.Create<HR_Position>();
        }

		public static HR_Position Fetch(System.Linq.Expressions.Expression<Func<HR_Position, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_Position>(exp,values);
            return EF.DataPortal.Fetch<HR_Position>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_Positions))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_Positions:ReadOnlyListBase<HR_Positions,HR_Position>
    {
        #region Factory Methods

        public static HR_Positions Fetch()
        {
            return EF.DataPortal.Fetch<HR_Positions>();
        }

		public static HR_Positions Fetch(System.Linq.Expressions.Expression<Func<HR_Position, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_Position>(exp,values);
            return EF.DataPortal.Fetch<HR_Positions>(lambda);
		}

		public static HR_Positions Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_Positions>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_Positions Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_Position, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_Positions>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_Position>(exp,values)});
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
