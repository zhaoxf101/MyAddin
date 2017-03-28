using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_Depart))]
#if Dev
    [RunLocal]
#endif

	public class Sys_Depart:ReadOnlyBase<Sys_Depart>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string DepName
        {
            get ;
            set ;
        }

		
        public string PositionCode
        {
            get ;
            set ;
        }

		
        public string DepLeader
        {
            get ;
            set ;
        }

		
        public string DepTypeCode
        {
            get ;
            set ;
        }

		
        public string DepAddr
        {
            get ;
            set ;
        }

		
        public string DepPhone
        {
            get ;
            set ;
        }

		
        public string DepLevel
        {
            get ;
            set ;
        }

		
        public string PrimDepCode
        {
            get ;
            set ;
        }

		
        public string DepDescr
        {
            get ;
            set ;
        }

		
        public bool? AsLogUnit
        {
            get ;
            set ;
        }

		
        public bool? Tax
        {
            get ;
            set ;
        }

		
        public string DealRange
        {
            get ;
            set ;
        }

		
        public string StatisticRangeCode
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

		
        public bool? IsBud
        {
            get ;
            set ;
        }

		
        public bool IsProj
        {
            get ;
            set ;
        }

		
        public string ParentId
        {
            get ;
            set ;
        }

		
        public bool EndNode
        {
            get ;
            set ;
        }

		
        public int? SortOrder
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

		
        public string Memo
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

		public static Sys_Depart Create()
        {
            return EF.DataPortal.Create<Sys_Depart>();
        }

		public static Sys_Depart Fetch(System.Linq.Expressions.Expression<Func<Sys_Depart, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_Depart>(exp,values);
            return EF.DataPortal.Fetch<Sys_Depart>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_Departs))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_Departs:ReadOnlyListBase<Sys_Departs,Sys_Depart>
    {
        #region Factory Methods

        public static Sys_Departs Fetch()
        {
            return EF.DataPortal.Fetch<Sys_Departs>();
        }

		public static Sys_Departs Fetch(System.Linq.Expressions.Expression<Func<Sys_Depart, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_Depart>(exp,values);
            return EF.DataPortal.Fetch<Sys_Departs>(lambda);
		}

		public static Sys_Departs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_Departs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_Departs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_Depart, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_Departs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_Depart>(exp,values)});
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
