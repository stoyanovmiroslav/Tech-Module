package animelist.controller;

import animelist.entity.Anime;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import animelist.bindingModel.AnimeBindingModel;
import animelist.repository.AnimeRepository;

import java.util.List;

@Controller
public class AnimeController {

	private final AnimeRepository animeRepository;

	@Autowired
	public AnimeController(AnimeRepository animeRepository) {
		this.animeRepository = animeRepository;
	}

	@GetMapping("/")
	public String index(Model model) {
		List<Anime> animes =  this.animeRepository.findAll();
		model.addAttribute("animes", animes);
		model.addAttribute("view", "anime/index");
		return "base-layout";
	}

	@GetMapping("/create")
	public String create(Model model) {
		model.addAttribute("anime", new AnimeBindingModel());
		model.addAttribute("view", "anime/create");
		return "base-layout";
	}

	@PostMapping("/create")
	public String createProcess(Model model, AnimeBindingModel animeBindingModel, BindingResult bindingResult) {
		if (bindingResult.hasErrors()) {
			model.addAttribute("message", "Invalid data.");
			model.addAttribute("anime", animeBindingModel);
			model.addAttribute("view", "anime/create");
			return "base-layout";
	}

	  Anime f = new Anime();
        f.setName(animeBindingModel.getName());
		f.setDescription(animeBindingModel.getDescription());
		f.setWatched(animeBindingModel.getWatched());
		f.setRating(animeBindingModel.getRating());

		animeRepository.saveAndFlush(f);

        return "redirect:/";
	}
	@GetMapping("/delete/{id}")
	public String delete(Model model, @PathVariable int id) {
		Anime anime = animeRepository.findOne(id);
		if (anime != null) {
			model.addAttribute("anime", anime);
			model.addAttribute("view", "anime/delete");
			return "base-layout";
		}
		return "redirect:/";
	}

	@PostMapping("/delete/{id}")
	public String deleteProcess(Model model, @PathVariable int id, AnimeBindingModel animeBindingModel) {
		try {
			animeRepository.delete(id);
		} catch (Exception ex) {
			// Task was not found -> do nothing
		}
		return "redirect:/";
		}
}
