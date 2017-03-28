using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjPubUType))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjPubUType:ReadOnlyBase<PM_ProjPubUType>
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

		
        public string UType
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

		public static PM_ProjPubUType Create()
        {
            return EF.DataPortal.Create<PM_ProjPubUType>();
        }

		public static PM_ProjPubUType Fetch(System.Linq.Expressions.Expression<Func<PM_ProjPubUType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjPubUType>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjPubUType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjPubUTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjPubUTypes:ReadOnlyListBase<PM_ProjPubUTypes,PM_ProjPubUType>
    {
        #region Factory Methods

        public static PM_ProjPubUTypes Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjPubUTypes>();
        }

		public static PM_ProjPubUTypes Fetch(System.Linq.Expressions.Expression<Func<PM_ProjPubUType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjPubUType>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjPubUTypes>(lambda);
		}

		public static PM_ProjPubUTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjPubUTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjPubUTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjPubUType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjPubUTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjPubUType>(exp,values)});
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
