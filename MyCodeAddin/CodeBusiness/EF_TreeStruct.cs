using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_TreeStruct))]
#if Dev
    [RunLocal]
#endif

	public class EF_TreeStruct:ReadOnlyBase<EF_TreeStruct>
    {
        #region Business Methods

		
        public string TableName
        {
            get ;
            set ;
        }

		
        public string ObjectId
        {
            get ;
            set ;
        }

		
        public string ParentId
        {
            get ;
            set ;
        }

		
        public int NodeLevel
        {
            get ;
            set ;
        }

		
        public int SortOrder
        {
            get ;
            set ;
        }

		
        public bool EndNode
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_TreeStruct Create()
        {
            return EF.DataPortal.Create<EF_TreeStruct>();
        }

		public static EF_TreeStruct Fetch(System.Linq.Expressions.Expression<Func<EF_TreeStruct, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_TreeStruct>(exp,values);
            return EF.DataPortal.Fetch<EF_TreeStruct>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_TreeStructs))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_TreeStructs:ReadOnlyListBase<EF_TreeStructs,EF_TreeStruct>
    {
        #region Factory Methods

        public static EF_TreeStructs Fetch()
        {
            return EF.DataPortal.Fetch<EF_TreeStructs>();
        }

		public static EF_TreeStructs Fetch(System.Linq.Expressions.Expression<Func<EF_TreeStruct, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_TreeStruct>(exp,values);
            return EF.DataPortal.Fetch<EF_TreeStructs>(lambda);
		}

		public static EF_TreeStructs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_TreeStructs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_TreeStructs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_TreeStruct, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_TreeStructs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_TreeStruct>(exp,values)});
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
