using FluentValidation;
using FluentValidation.AspNetCore;
using TTClothesStore_Models.Request;

namespace TTClothesStoreApp.Validators
{
    public class TestRequestValidation : AbstractValidator<GetAllItemsByShopIdRequest>
    {
        public TestRequestValidation()
        {
            RuleFor(x => x.ShopId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0).WithMessage("> 0");
        }
    }
}
