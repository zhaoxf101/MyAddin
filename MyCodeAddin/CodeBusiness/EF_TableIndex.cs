using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_TableIndex))]
#if Dev
    [RunLocal]
#endif

	public class EF_TableIndex:ReadOnlyBase<EF_TableIndex>
    {
        #region Business Methods

		
        public string TableName
        {
            get ;
            set ;
        }

		
        public string IndexName
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public bool PKeyX
        {
            get ;
            set ;
        }

		
        public bool UniqueX
        {
            get ;
            set ;
        }

		
        public bool DBIndexX
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

		public static EF_TableIndex Create()
        {
            return EF.DataPortal.Create<EF_TableIndex>();
        }

		public static EF_TableIndex Fetch(System.Linq.Expressions.Expression<Func<EF_TableIndex, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_TableIndex>(exp,values);
            return EF.DataPortal.Fetch<EF_TableIndex>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_TableIndexs))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_TableIndexs:ReadOnlyListBase<EF_TableIndexs,EF_TableIndex>
    {
        #region Factory Methods

        public static EF_TableIndexs Fetch()
        {
            return EF.DataPortal.Fetch<EF_TableIndexs>();
        }

		public static EF_TableIndexs Fetch(System.Linq.Expressions.Expression<Func<EF_TableIndex, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_TableIndex>(exp,values);
            return EF.DataPortal.Fetch<EF_TableIndexs>(lambda);
		}

		public static EF_TableIndexs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_TableIndexs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_TableIndexs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_TableIndex, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_TableIndexs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_TableIndex>(exp,values)});
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
