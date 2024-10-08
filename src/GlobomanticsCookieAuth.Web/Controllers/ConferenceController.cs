﻿using Globomantics.ApplicationCore.Interfaces;
using Globomantics.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GlobomanticsCookieAuth.Web.Controllers;

public class ConferenceController : Controller
{
    private readonly IConferenceRepository repo;

    public ConferenceController(IConferenceRepository repo)
    {
        this.repo = repo;
    }

    [AllowAnonymous]
    public IActionResult Index()
    {
        ViewBag.Title = "Organizer - Conference Overview";
        return View(repo.GetAll());
    }

    public IActionResult Add()
    {
        ViewBag.Title = "Organizer - Add Conference";
        return View(new ConferenceModel());
    }

    [HttpPost]
    public IActionResult Add(ConferenceModel model)
    {
        if (ModelState.IsValid)
            repo.Add(model);

        return RedirectToAction("Index");
    }
}
