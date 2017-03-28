using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_UserTid))]
#if Dev
    [RunLocal]
#endif

	public class EF_UserTid:ReadOnlyBase<EF_UserTid>
    {
        #region Business Methods

		
        public Guid Tid
        {
            get ;
            set ;
        }

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BName
        {
            get ;
            set ;
        }

		
        public string UIType
        {
            get ;
            set ;
        }

		
        public string MachineId
        {
            get ;
            set ;
        }

		
        public string IpAddress
        {
            get ;
            set ;
        }

		
        public DateTime? LoginDate
        {
            get ;
            set ;
        }

		
        public DateTime? LogoutDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_UserTid Create()
        {
            return EF.DataPortal.Create<EF_UserTid>();
        }

		public static EF_UserTid Fetch(System.Linq.Expressions.Expression<Func<EF_UserTid, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_UserTid>(exp,values);
            return EF.DataPortal.Fetch<EF_UserTid>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_UserTids))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_UserTids:ReadOnlyListBase<EF_UserTids,EF_UserTid>
    {
        #region Factory Methods

        public static EF_UserTids Fetch()
        {
            return EF.DataPortal.Fetch<EF_UserTids>();
        }

		public static EF_UserTids Fetch(System.Linq.Expressions.Expression<Func<EF_UserTid, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_UserTid>(exp,values);
            return EF.DataPortal.Fetch<EF_UserTids>(lambda);
		}

		public static EF_UserTids Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_UserTids>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_UserTids Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_UserTid, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_UserTids>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_UserTid>(exp,values)});
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
