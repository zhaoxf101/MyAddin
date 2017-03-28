using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjMember))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjMember:ReadOnlyBase<PM_ProjMember>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string ProjMemberNo
        {
            get ;
            set ;
        }

		
        public string ProjMemberTypeCode
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string DepCode
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

		
        public bool IsPLeader
        {
            get ;
            set ;
        }

		
        public bool IsTLeader
        {
            get ;
            set ;
        }

		
        public bool CanBud
        {
            get ;
            set ;
        }

		
        public bool CanLoan
        {
            get ;
            set ;
        }

		
        public bool CanExp
        {
            get ;
            set ;
        }

		
        public bool CanAppInv
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

		public static PM_ProjMember Create()
        {
            return EF.DataPortal.Create<PM_ProjMember>();
        }

		public static PM_ProjMember Fetch(System.Linq.Expressions.Expression<Func<PM_ProjMember, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjMember>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjMember>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjMembers))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjMembers:ReadOnlyListBase<PM_ProjMembers,PM_ProjMember>
    {
        #region Factory Methods

        public static PM_ProjMembers Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjMembers>();
        }

		public static PM_ProjMembers Fetch(System.Linq.Expressions.Expression<Func<PM_ProjMember, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjMember>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjMembers>(lambda);
		}

		public static PM_ProjMembers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjMembers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjMembers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjMember, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjMembers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjMember>(exp,values)});
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
