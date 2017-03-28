using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(MM_Material))]
#if Dev
    [RunLocal]
#endif

	public class MM_Material:ReadOnlyBase<MM_Material>
    {
        #region Business Methods

		
        public string MaterialCode
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
        public bool? IsDel
        {
            get ;
            set ;
        }

		
        public string MatType
        {
            get ;
            set ;
        }

		
        public string MatGrp
        {
            get ;
            set ;
        }

		
        public string OldMatCode
        {
            get ;
            set ;
        }

		
        public string UnitCode
        {
            get ;
            set ;
        }

		
        public string BUnitCode
        {
            get ;
            set ;
        }

		
        public string RoughWT
        {
            get ;
            set ;
        }

		
        public decimal? NetWT
        {
            get ;
            set ;
        }

		
        public decimal? WTUnit
        {
            get ;
            set ;
        }

		
        public string VOLUnit
        {
            get ;
            set ;
        }

		
        public string Container
        {
            get ;
            set ;
        }

		
        public decimal? Len
        {
            get ;
            set ;
        }

		
        public decimal? Width
        {
            get ;
            set ;
        }

		
        public decimal? High
        {
            get ;
            set ;
        }

		
        public string LenUnit
        {
            get ;
            set ;
        }

		
        public bool? KZKUP
        {
            get ;
            set ;
        }

		
        public DateTime? DelDate
        {
            get ;
            set ;
        }

		
        public bool? Active
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

		public static MM_Material Create()
        {
            return EF.DataPortal.Create<MM_Material>();
        }

		public static MM_Material Fetch(System.Linq.Expressions.Expression<Func<MM_Material, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<MM_Material>(exp,values);
            return EF.DataPortal.Fetch<MM_Material>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(MM_Materials))]
#if Dev
    [RunLocal]
#endif
	
	public class MM_Materials:ReadOnlyListBase<MM_Materials,MM_Material>
    {
        #region Factory Methods

        public static MM_Materials Fetch()
        {
            return EF.DataPortal.Fetch<MM_Materials>();
        }

		public static MM_Materials Fetch(System.Linq.Expressions.Expression<Func<MM_Material, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<MM_Material>(exp,values);
            return EF.DataPortal.Fetch<MM_Materials>(lambda);
		}

		public static MM_Materials Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<MM_Materials>(new Paging { Page=page,RowCount=rowCount});
        }

        public static MM_Materials Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<MM_Material, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<MM_Materials>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<MM_Material>(exp,values)});
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
