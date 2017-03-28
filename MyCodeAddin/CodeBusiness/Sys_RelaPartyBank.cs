using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_RelaPartyBank))]
#if Dev
    [RunLocal]
#endif

	public class Sys_RelaPartyBank:ReadOnlyBase<Sys_RelaPartyBank>
    {
        #region Business Methods

		
        public string RelPartyCode
        {
            get ;
            set ;
        }

		
        public int Position
        {
            get ;
            set ;
        }

		
        public string BankCardNo
        {
            get ;
            set ;
        }

		
        public string BankName
        {
            get ;
            set ;
        }

		
        public string AccountName
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

		public static Sys_RelaPartyBank Create()
        {
            return EF.DataPortal.Create<Sys_RelaPartyBank>();
        }

		public static Sys_RelaPartyBank Fetch(System.Linq.Expressions.Expression<Func<Sys_RelaPartyBank, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_RelaPartyBank>(exp,values);
            return EF.DataPortal.Fetch<Sys_RelaPartyBank>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_RelaPartyBanks))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_RelaPartyBanks:ReadOnlyListBase<Sys_RelaPartyBanks,Sys_RelaPartyBank>
    {
        #region Factory Methods

        public static Sys_RelaPartyBanks Fetch()
        {
            return EF.DataPortal.Fetch<Sys_RelaPartyBanks>();
        }

		public static Sys_RelaPartyBanks Fetch(System.Linq.Expressions.Expression<Func<Sys_RelaPartyBank, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_RelaPartyBank>(exp,values);
            return EF.DataPortal.Fetch<Sys_RelaPartyBanks>(lambda);
		}

		public static Sys_RelaPartyBanks Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_RelaPartyBanks>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_RelaPartyBanks Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_RelaPartyBank, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_RelaPartyBanks>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_RelaPartyBank>(exp,values)});
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
