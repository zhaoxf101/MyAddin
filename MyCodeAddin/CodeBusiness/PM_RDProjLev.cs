using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_RDProjLev))]
#if Dev
    [RunLocal]
#endif

	public class PM_RDProjLev:ReadOnlyBase<PM_RDProjLev>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string RDProjLevCode
        {
            get ;
            set ;
        }

		
        public string RDProjLevName
        {
            get ;
            set ;
        }

		
        public bool Active
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

		public static PM_RDProjLev Create()
        {
            return EF.DataPortal.Create<PM_RDProjLev>();
        }

		public static PM_RDProjLev Fetch(System.Linq.Expressions.Expression<Func<PM_RDProjLev, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_RDProjLev>(exp,values);
            return EF.DataPortal.Fetch<PM_RDProjLev>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_RDProjLevs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_RDProjLevs:ReadOnlyListBase<PM_RDProjLevs,PM_RDProjLev>
    {
        #region Factory Methods

        public static PM_RDProjLevs Fetch()
        {
            return EF.DataPortal.Fetch<PM_RDProjLevs>();
        }

		public static PM_RDProjLevs Fetch(System.Linq.Expressions.Expression<Func<PM_RDProjLev, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_RDProjLev>(exp,values);
            return EF.DataPortal.Fetch<PM_RDProjLevs>(lambda);
		}

		public static PM_RDProjLevs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_RDProjLevs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_RDProjLevs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_RDProjLev, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_RDProjLevs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_RDProjLev>(exp,values)});
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
