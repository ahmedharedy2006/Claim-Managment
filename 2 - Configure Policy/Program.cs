builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Policy1", policy => policy.RequireClaim("First Claim"));
    options.AddPolicy("Policy2", policy => policy.RequireClaim("Second Claim"));
});