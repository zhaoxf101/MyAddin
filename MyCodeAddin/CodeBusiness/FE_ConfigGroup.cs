using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FE_ConfigGroup))]
#if Dev
    [RunLocal]
#endif

	public class FE_ConfigGroup:ReadOnlyBase<FE_ConfigGroup>
    {
        #region Business Methods

		
        public string ConfigGroupCode
        {
            get ;
            set ;
        }

		
        public string ConfigGroupName
        {
            get ;
            set ;
        }

		
        public string ConfigGroupDesc
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FE_ConfigGroup Create()
        {
            return EF.DataPortal.Create<FE_ConfigGroup>();
        }

		public static FE_ConfigGroup Fetch(System.Linq.Expressions.Expression<Func<FE_ConfigGroup, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FE_ConfigGroup>(exp,values);
            return EF.DataPortal.Fetch<FE_ConfigGroup>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FE_ConfigGroups))]
#if Dev
    [RunLocal]
#endif
	
	public class FE_ConfigGroups:ReadOnlyListBase<FE_ConfigGroups,FE_ConfigGroup>
    {
        #region Factory Methods

        public static FE_ConfigGroups Fetch()
        {
            return EF.DataPortal.Fetch<FE_ConfigGroups>();
        }

		public static FE_ConfigGroups Fetch(System.Linq.Expressions.Expression<Func<FE_ConfigGroup, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FE_ConfigGroup>(exp,values);
            return EF.DataPortal.Fetch<FE_ConfigGroups>(lambda);
		}

		public static FE_ConfigGroups Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FE_ConfigGroups>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FE_ConfigGroups Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FE_ConfigGroup, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FE_ConfigGroups>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FE_ConfigGroup>(exp,values)});
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
