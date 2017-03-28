using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjIncDet))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjIncDet:ReadOnlyBase<PM_ProjIncDet>
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

		
        public string IncDetCode
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

		public static PM_ProjIncDet Create()
        {
            return EF.DataPortal.Create<PM_ProjIncDet>();
        }

		public static PM_ProjIncDet Fetch(System.Linq.Expressions.Expression<Func<PM_ProjIncDet, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjIncDet>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjIncDet>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjIncDets))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjIncDets:ReadOnlyListBase<PM_ProjIncDets,PM_ProjIncDet>
    {
        #region Factory Methods

        public static PM_ProjIncDets Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjIncDets>();
        }

		public static PM_ProjIncDets Fetch(System.Linq.Expressions.Expression<Func<PM_ProjIncDet, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjIncDet>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjIncDets>(lambda);
		}

		public static PM_ProjIncDets Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjIncDets>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjIncDets Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjIncDet, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjIncDets>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjIncDet>(exp,values)});
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
