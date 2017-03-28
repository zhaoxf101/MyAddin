using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_FieldSet))]
#if Dev
    [RunLocal]
#endif

	public class FI_FieldSet:ReadOnlyBase<FI_FieldSet>
    {
        #region Business Methods

		
        public string FieldSet
        {
            get ;
            set ;
        }

		
        public string DText
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

		public static FI_FieldSet Create()
        {
            return EF.DataPortal.Create<FI_FieldSet>();
        }

		public static FI_FieldSet Fetch(System.Linq.Expressions.Expression<Func<FI_FieldSet, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_FieldSet>(exp,values);
            return EF.DataPortal.Fetch<FI_FieldSet>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_FieldSets))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_FieldSets:ReadOnlyListBase<FI_FieldSets,FI_FieldSet>
    {
        #region Factory Methods

        public static FI_FieldSets Fetch()
        {
            return EF.DataPortal.Fetch<FI_FieldSets>();
        }

		public static FI_FieldSets Fetch(System.Linq.Expressions.Expression<Func<FI_FieldSet, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_FieldSet>(exp,values);
            return EF.DataPortal.Fetch<FI_FieldSets>(lambda);
		}

		public static FI_FieldSets Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_FieldSets>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_FieldSets Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_FieldSet, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_FieldSets>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_FieldSet>(exp,values)});
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
