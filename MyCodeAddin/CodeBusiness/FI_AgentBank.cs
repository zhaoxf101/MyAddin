using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_AgentBank))]
#if Dev
    [RunLocal]
#endif

	public class FI_AgentBank:ReadOnlyBase<FI_AgentBank>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AgentId
        {
            get ;
            set ;
        }

		
        public string Account
        {
            get ;
            set ;
        }

		
        public string AccName
        {
            get ;
            set ;
        }

		
        public string BankName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_AgentBank Create()
        {
            return EF.DataPortal.Create<FI_AgentBank>();
        }

		public static FI_AgentBank Fetch(System.Linq.Expressions.Expression<Func<FI_AgentBank, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_AgentBank>(exp,values);
            return EF.DataPortal.Fetch<FI_AgentBank>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_AgentBanks))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_AgentBanks:ReadOnlyListBase<FI_AgentBanks,FI_AgentBank>
    {
        #region Factory Methods

        public static FI_AgentBanks Fetch()
        {
            return EF.DataPortal.Fetch<FI_AgentBanks>();
        }

		public static FI_AgentBanks Fetch(System.Linq.Expressions.Expression<Func<FI_AgentBank, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_AgentBank>(exp,values);
            return EF.DataPortal.Fetch<FI_AgentBanks>(lambda);
		}

		public static FI_AgentBanks Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_AgentBanks>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_AgentBanks Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_AgentBank, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_AgentBanks>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_AgentBank>(exp,values)});
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
