using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_RelationGroup))]
#if Dev
    [RunLocal]
#endif

	public class HR_RelationGroup:ReadOnlyBase<HR_RelationGroup>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string RelationGroup
        {
            get ;
            set ;
        }

		
        public string RelationGroupText
        {
            get ;
            set ;
        }

		
        public string WebObject
        {
            get ;
            set ;
        }

		
        public string WinObject
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_RelationGroup Create()
        {
            return EF.DataPortal.Create<HR_RelationGroup>();
        }

		public static HR_RelationGroup Fetch(System.Linq.Expressions.Expression<Func<HR_RelationGroup, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_RelationGroup>(exp,values);
            return EF.DataPortal.Fetch<HR_RelationGroup>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_RelationGroups))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_RelationGroups:ReadOnlyListBase<HR_RelationGroups,HR_RelationGroup>
    {
        #region Factory Methods

        public static HR_RelationGroups Fetch()
        {
            return EF.DataPortal.Fetch<HR_RelationGroups>();
        }

		public static HR_RelationGroups Fetch(System.Linq.Expressions.Expression<Func<HR_RelationGroup, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_RelationGroup>(exp,values);
            return EF.DataPortal.Fetch<HR_RelationGroups>(lambda);
		}

		public static HR_RelationGroups Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_RelationGroups>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_RelationGroups Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_RelationGroup, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_RelationGroups>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_RelationGroup>(exp,values)});
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
