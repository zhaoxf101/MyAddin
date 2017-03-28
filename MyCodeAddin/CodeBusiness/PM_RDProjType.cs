using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_RDProjType))]
#if Dev
    [RunLocal]
#endif

	public class PM_RDProjType:ReadOnlyBase<PM_RDProjType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string RDProjTypeCode
        {
            get ;
            set ;
        }

		
        public string RDProjTypeName
        {
            get ;
            set ;
        }

		
        public string PCode
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

		public static PM_RDProjType Create()
        {
            return EF.DataPortal.Create<PM_RDProjType>();
        }

		public static PM_RDProjType Fetch(System.Linq.Expressions.Expression<Func<PM_RDProjType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_RDProjType>(exp,values);
            return EF.DataPortal.Fetch<PM_RDProjType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_RDProjTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_RDProjTypes:ReadOnlyListBase<PM_RDProjTypes,PM_RDProjType>
    {
        #region Factory Methods

        public static PM_RDProjTypes Fetch()
        {
            return EF.DataPortal.Fetch<PM_RDProjTypes>();
        }

		public static PM_RDProjTypes Fetch(System.Linq.Expressions.Expression<Func<PM_RDProjType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_RDProjType>(exp,values);
            return EF.DataPortal.Fetch<PM_RDProjTypes>(lambda);
		}

		public static PM_RDProjTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_RDProjTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_RDProjTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_RDProjType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_RDProjTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_RDProjType>(exp,values)});
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
