using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_FKeyTable))]
#if Dev
    [RunLocal]
#endif

	public class EF_FKeyTable:ReadOnlyBase<EF_FKeyTable>
    {
        #region Business Methods

		
        public string TableName
        {
            get ;
            set ;
        }

		
        public string TableField
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public string CheckTable
        {
            get ;
            set ;
        }

		
        public bool InputCheckX
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

		public static EF_FKeyTable Create()
        {
            return EF.DataPortal.Create<EF_FKeyTable>();
        }

		public static EF_FKeyTable Fetch(System.Linq.Expressions.Expression<Func<EF_FKeyTable, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_FKeyTable>(exp,values);
            return EF.DataPortal.Fetch<EF_FKeyTable>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_FKeyTables))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_FKeyTables:ReadOnlyListBase<EF_FKeyTables,EF_FKeyTable>
    {
        #region Factory Methods

        public static EF_FKeyTables Fetch()
        {
            return EF.DataPortal.Fetch<EF_FKeyTables>();
        }

		public static EF_FKeyTables Fetch(System.Linq.Expressions.Expression<Func<EF_FKeyTable, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_FKeyTable>(exp,values);
            return EF.DataPortal.Fetch<EF_FKeyTables>(lambda);
		}

		public static EF_FKeyTables Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_FKeyTables>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_FKeyTables Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_FKeyTable, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_FKeyTables>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_FKeyTable>(exp,values)});
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
