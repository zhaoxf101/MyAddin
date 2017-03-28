using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_ConfigGroup))]
#if Dev
    [RunLocal]
#endif

	public class EF_ConfigGroup:ReadOnlyBase<EF_ConfigGroup>
    {
        #region Business Methods

		
        public string ConfigGroup
        {
            get ;
            set ;
        }

		
        public string AGBlock
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public bool ClientX
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

		public static EF_ConfigGroup Create()
        {
            return EF.DataPortal.Create<EF_ConfigGroup>();
        }

		public static EF_ConfigGroup Fetch(System.Linq.Expressions.Expression<Func<EF_ConfigGroup, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_ConfigGroup>(exp,values);
            return EF.DataPortal.Fetch<EF_ConfigGroup>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_ConfigGroups))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_ConfigGroups:ReadOnlyListBase<EF_ConfigGroups,EF_ConfigGroup>
    {
        #region Factory Methods

        public static EF_ConfigGroups Fetch()
        {
            return EF.DataPortal.Fetch<EF_ConfigGroups>();
        }

		public static EF_ConfigGroups Fetch(System.Linq.Expressions.Expression<Func<EF_ConfigGroup, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_ConfigGroup>(exp,values);
            return EF.DataPortal.Fetch<EF_ConfigGroups>(lambda);
		}

		public static EF_ConfigGroups Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_ConfigGroups>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_ConfigGroups Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_ConfigGroup, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_ConfigGroups>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_ConfigGroup>(exp,values)});
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
