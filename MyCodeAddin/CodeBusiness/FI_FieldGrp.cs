using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_FieldGrp))]
#if Dev
    [RunLocal]
#endif

	public class FI_FieldGrp:ReadOnlyBase<FI_FieldGrp>
    {
        #region Business Methods

		
        public string FieldSet
        {
            get ;
            set ;
        }

		
        public string FieldGrp
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string Status
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

		public static FI_FieldGrp Create()
        {
            return EF.DataPortal.Create<FI_FieldGrp>();
        }

		public static FI_FieldGrp Fetch(System.Linq.Expressions.Expression<Func<FI_FieldGrp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_FieldGrp>(exp,values);
            return EF.DataPortal.Fetch<FI_FieldGrp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_FieldGrps))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_FieldGrps:ReadOnlyListBase<FI_FieldGrps,FI_FieldGrp>
    {
        #region Factory Methods

        public static FI_FieldGrps Fetch()
        {
            return EF.DataPortal.Fetch<FI_FieldGrps>();
        }

		public static FI_FieldGrps Fetch(System.Linq.Expressions.Expression<Func<FI_FieldGrp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_FieldGrp>(exp,values);
            return EF.DataPortal.Fetch<FI_FieldGrps>(lambda);
		}

		public static FI_FieldGrps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_FieldGrps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_FieldGrps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_FieldGrp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_FieldGrps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_FieldGrp>(exp,values)});
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
