using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_RDProjSubType))]
#if Dev
    [RunLocal]
#endif

	public class PM_RDProjSubType:ReadOnlyBase<PM_RDProjSubType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string RDProjSubTypeCode
        {
            get ;
            set ;
        }

		
        public string RDProjSubTypeName
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

		public static PM_RDProjSubType Create()
        {
            return EF.DataPortal.Create<PM_RDProjSubType>();
        }

		public static PM_RDProjSubType Fetch(System.Linq.Expressions.Expression<Func<PM_RDProjSubType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_RDProjSubType>(exp,values);
            return EF.DataPortal.Fetch<PM_RDProjSubType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_RDProjSubTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_RDProjSubTypes:ReadOnlyListBase<PM_RDProjSubTypes,PM_RDProjSubType>
    {
        #region Factory Methods

        public static PM_RDProjSubTypes Fetch()
        {
            return EF.DataPortal.Fetch<PM_RDProjSubTypes>();
        }

		public static PM_RDProjSubTypes Fetch(System.Linq.Expressions.Expression<Func<PM_RDProjSubType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_RDProjSubType>(exp,values);
            return EF.DataPortal.Fetch<PM_RDProjSubTypes>(lambda);
		}

		public static PM_RDProjSubTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_RDProjSubTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_RDProjSubTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_RDProjSubType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_RDProjSubTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_RDProjSubType>(exp,values)});
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
