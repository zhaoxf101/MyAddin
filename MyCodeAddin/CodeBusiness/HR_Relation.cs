using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_Relation))]
#if Dev
    [RunLocal]
#endif

	public class HR_Relation:ReadOnlyBase<HR_Relation>
    {
        #region Business Methods

		
        public string RelationCode
        {
            get ;
            set ;
        }

		
        public string RelationName
        {
            get ;
            set ;
        }

		
        public bool IsOnly
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_Relation Create()
        {
            return EF.DataPortal.Create<HR_Relation>();
        }

		public static HR_Relation Fetch(System.Linq.Expressions.Expression<Func<HR_Relation, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_Relation>(exp,values);
            return EF.DataPortal.Fetch<HR_Relation>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_Relations))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_Relations:ReadOnlyListBase<HR_Relations,HR_Relation>
    {
        #region Factory Methods

        public static HR_Relations Fetch()
        {
            return EF.DataPortal.Fetch<HR_Relations>();
        }

		public static HR_Relations Fetch(System.Linq.Expressions.Expression<Func<HR_Relation, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_Relation>(exp,values);
            return EF.DataPortal.Fetch<HR_Relations>(lambda);
		}

		public static HR_Relations Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_Relations>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_Relations Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_Relation, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_Relations>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_Relation>(exp,values)});
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
