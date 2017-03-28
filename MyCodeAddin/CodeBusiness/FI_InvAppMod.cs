using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_InvAppMod))]
#if Dev
    [RunLocal]
#endif

	public class FI_InvAppMod:ReadOnlyBase<FI_InvAppMod>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string InvAppModCode
        {
            get ;
            set ;
        }

		
        public string InvAppModName
        {
            get ;
            set ;
        }

		
        public string DAccCode
        {
            get ;
            set ;
        }

		
        public string CAccCode
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string WFID
        {
            get ;
            set ;
        }

		
        public bool Active
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

		public static FI_InvAppMod Create()
        {
            return EF.DataPortal.Create<FI_InvAppMod>();
        }

		public static FI_InvAppMod Fetch(System.Linq.Expressions.Expression<Func<FI_InvAppMod, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_InvAppMod>(exp,values);
            return EF.DataPortal.Fetch<FI_InvAppMod>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_InvAppMods))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_InvAppMods:ReadOnlyListBase<FI_InvAppMods,FI_InvAppMod>
    {
        #region Factory Methods

        public static FI_InvAppMods Fetch()
        {
            return EF.DataPortal.Fetch<FI_InvAppMods>();
        }

		public static FI_InvAppMods Fetch(System.Linq.Expressions.Expression<Func<FI_InvAppMod, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_InvAppMod>(exp,values);
            return EF.DataPortal.Fetch<FI_InvAppMods>(lambda);
		}

		public static FI_InvAppMods Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_InvAppMods>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_InvAppMods Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_InvAppMod, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_InvAppMods>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_InvAppMod>(exp,values)});
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
